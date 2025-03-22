using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class GenererListeMeilleureEtu : Form
    {
        // Chaîne de connexion à la base de données SQL Server
        private string connectionString = "Data Source=DESKTOP-7DUFCH2;Initial Catalog=DBGestion;Integrated Security=True;Connect Timeout=60;";

        public GenererListeMeilleureEtu()
        {
            InitializeComponent();
            ChargerClasses();
        }

        private void ChargerClasses()
        {
            try
            {
                comboBoxClasse.Items.Clear(); // Nettoyer avant de recharger
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Id, NomClasse FROM Classes"; // Charger les classes
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            // Ajouter chaque classe à la ComboBox sous forme de KeyValuePair
                            comboBoxClasse.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
                comboBoxClasse.DisplayMember = "Value"; // Affiche les noms des classes
                comboBoxClasse.ValueMember = "Key";    // Utilise l'ID comme clé
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des classes : " + ex.Message);
            }
        }

        private void GenererPDF_Click(object sender, EventArgs e)
        {
            if (comboBoxClasse.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe.");
                return;
            }
            // Récupérer la classe sélectionnée
            var selectedClass = (KeyValuePair<int, string>)comboBoxClasse.SelectedItem;
            int classId = selectedClass.Key;
            string className = selectedClass.Value;
            // Récupérer les meilleurs étudiants de la classe
            DataTable dt = RecupererMeilleursEtudiants(classId);
            if (dt.Rows.Count > 0)
            {
                ExporterPDF(dt, className);
            }
            else
            {
                MessageBox.Show("Aucune donnée trouvée pour cette classe.");
            }
        }

        private void GenererEXEL_Click(object sender, EventArgs e)
        {
            if (comboBoxClasse.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe.");
                return;
            }

            var selectedClass = (KeyValuePair<int, string>)comboBoxClasse.SelectedItem;
            int classId = selectedClass.Key;
            string className = selectedClass.Value;

            DataTable dt = RecupererMeilleursEtudiants(classId);
            if (dt.Rows.Count > 0)
            {
                ExporterExcel(dt, className);
            }
            else
            {
                MessageBox.Show("Aucune donnée trouvée pour cette classe.");
            }
        }

        private DataTable RecupererMeilleursEtudiants(int classId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Requête SQL pour récupérer les 3 meilleurs étudiants de la classe
                    string query = @"
                        SELECT TOP 3 e.Nom, e.Prenom, AVG(n.Notes) AS Moyenne
                        FROM Etudiants e
                        INNER JOIN Notes n ON n.Etudiant_Id = e.Id
                        WHERE e.IdClasse = @classId
                        GROUP BY e.Id, e.Nom, e.Prenom
                        ORDER BY Moyenne DESC";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@classId", classId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);// Remplir le DataTable avec les résultats
                    }
                }

                // Ajouter une colonne pour le classement
                dt.Columns.Add("Rang", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["Rang"] = i + 1; // Rang en fonction de l'ordre
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message);
            }
            return dt;
        }

        private void ExporterPDF(DataTable dt, string className)
        {
            try
            {
                // Boîte de dialogue pour choisir l'emplacement du fichier
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"MeilleursEtudiants_{className}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Ajouter un titre
                        pdfDoc.Add(new Paragraph($"Liste des meilleurs étudiants de la classe {className}"));

                        // Créer un tableau pour les données
                        PdfPTable pdfTable = new PdfPTable(dt.Columns.Count);
                        pdfTable.WidthPercentage = 100;

                        // Ajouter les en-têtes
                        foreach (DataColumn column in dt.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                            pdfTable.AddCell(cell);
                        }

                        // Ajouter les lignes
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (var item in row.ItemArray)
                            {
                                pdfTable.AddCell(item.ToString());
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Export en PDF réussi !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'export en PDF : " + ex.Message);
            }
        }
        private void ExporterExcel(DataTable dt, string className)
        {
            try
            {
                // Boîte de dialogue pour choisir l'emplacement du fichier
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Fichiers Excel (*.xlsx)|*.xlsx",
                    FileName = $"MeilleursEtudiants_{className}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Configurer le contexte de licence pour EPPlus
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    // Créer une feuille Excel
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Meilleurs Étudiants");

                        // Ajouter un titre
                        worksheet.Cells[1, 1].Value = $"Liste des meilleurs étudiants de la classe {className}";
                        worksheet.Cells[1, 1, 1, dt.Columns.Count].Merge = true;

                        // Ajouter les en-têtes
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            worksheet.Cells[2, i + 1].Value = dt.Columns[i].ColumnName;
                        }

                        // Ajouter les données
                        for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                        {
                            for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                            {
                                worksheet.Cells[rowIndex + 3, colIndex + 1].Value = dt.Rows[rowIndex][colIndex].ToString();
                            }
                        }

                        // Sauvegarder le fichier
                        FileInfo fi = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fi);
                    }

                    MessageBox.Show("Export en Excel réussi !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'export en Excel : " + ex.Message);
            }
        }
    }
}
