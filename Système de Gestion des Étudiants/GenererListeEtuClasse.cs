using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using OfficeOpenXml;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class GenererListeEtuClasse : Form
    {
        // Chaîne de connexion à la base de données
        private string connectionString = "Data Source=DESKTOP-7DUFCH2;Initial Catalog=DBGestion;Integrated Security=True;Connect Timeout=60;";

        public GenererListeEtuClasse()
        {
            InitializeComponent();
            ChargerClasses(); // Charger les classes au démarrage de la fenêtre
        }

        private void ChargerClasses()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open(); // Ouvrir la connexion SQL
                    string query = "SELECT id, NomClasse FROM Classes"; // Requête pour récupérer les classes
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader(); // Exécuter la requête
                        while (reader.Read())
                        {
                            // Ajouter chaque classe à la ComboBox avec son ID
                            comboBoxClasse.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
                        }
                        comboBoxClasse.DisplayMember = "NomClasse"; // Afficher le nom de la classe
                        comboBoxClasse.ValueMember = "Key"; // Utiliser l'ID comme valeur
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des classes: " + ex.Message);
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

            // Récupérer les étudiants de la classe sélectionnée
            DataTable dt = RecupererEtudiantsParClasse(classId);
            if (dt.Rows.Count > 0)
            {
                ExporterPDF(dt, className); // Générer le PDF si des étudiants sont trouvés
            }
            else
            {
                MessageBox.Show("Aucun étudiant trouvé pour cette classe.");
            }
        }

        private void GenererEXEL_Click(object sender, EventArgs e)
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
            // Récupérer les étudiants de la classe sélectionnée
            DataTable dt = RecupererEtudiantsParClasse(classId);
            if (dt.Rows.Count > 0)
            {
                ExporterExcel(dt, className); // Générer l'Excel si des étudiants sont trouvés
            }
            else
            {
                MessageBox.Show("Aucun étudiant trouvé pour cette classe.");
            }
        }

        private DataTable RecupererEtudiantsParClasse(int classId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    // Requête SQL pour récupérer les étudiants de la classe
                    string query = "SELECT Nom, Prenom, DateNaissance, Email, Sexe, Adresse, Telephone FROM Etudiants WHERE Idclasse = @classId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@classId", classId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt); // Remplir le DataTable avec les résultats de la requête
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des étudiants: " + ex.Message);
            }
            return dt;
        }

        private void ExporterPDF(DataTable dt, string className)
        {
            try
            {
                // Boîte de dialogue pour choisir l'emplacement du fichier
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Fichiers PDF (*.pdf)|*.pdf",
                    FileName = $"Liste_Etudiants_{className}.pdf"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        // Créer un document PDF
                        Document doc = new Document(PageSize.A4);
                        PdfWriter.GetInstance(doc, fs);
                        doc.Open();
                        // Ajouter un titre au document
                        Paragraph title = new Paragraph($"Liste des étudiants de la classe {className}\n\n")
                        {
                            Alignment = Element.ALIGN_CENTER
                        };
                        doc.Add(title);
                        // Créer un tableau pour afficher les données
                        PdfPTable table = new PdfPTable(dt.Columns.Count);
                        foreach (DataColumn column in dt.Columns)
                        {
                            table.AddCell(new Phrase(column.ColumnName));// Ajouter les en-tête
                        }
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (var cell in row.ItemArray)
                            {
                                table.AddCell(new Phrase(cell.ToString())); // Ajouter les donné
                            }
                        }
                        doc.Add(table);// Ajouter le tableau au document
                        doc.Close();
                    }
                    MessageBox.Show("PDF généré avec succès!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du PDF: " + ex.Message);
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
                    FileName = $"Liste_Etudiants_{className}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Activer le mode licence non commerciale avant d'utiliser EPPlus
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage())
                    {

                        // Créer une feuille Excel
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"Liste des Etudiants {className}");

                        // Ajouter les entêtes de colonne
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dt.Columns[i].ColumnName;
                        }

                        // Ajouter les données de chaque étudiant
                        for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                        {
                            for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                            {
                                worksheet.Cells[rowIndex + 2, colIndex + 1].Value = dt.Rows[rowIndex][colIndex].ToString();
                            }
                        }

                        // Sauvegarde du fichier
                        FileInfo fi = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(fi);
                    }

                    MessageBox.Show("Fichier Excel généré avec succès!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération de l'Excel: " + ex.Message);
            }
        }

        private void GenererListeEtuClasse_Load(object sender, EventArgs e)
        {

        }
    }
}
