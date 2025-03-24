using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class GenererReleveEtu : Form
    {
        private string connectionString = "Data Source=DLS-NDONG-MASTE;Initial Catalog=DBGestion;Integrated Security=True;Connect Timeout=60;";

        public GenererReleveEtu()
        {
            InitializeComponent();
            ChargerEtudiants();
        }

        private void ChargerEtudiants()
        {
            try
            {
                comboBoxEtudiant.Items.Clear(); // Nettoyer avant rechargement
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT id, Nom, Prenom FROM Etudiants";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nomComplet = $"{reader.GetString(1)} {reader.GetString(2)}";
                            comboBoxEtudiant.Items.Add(new KeyValuePair<int, string>(id, nomComplet));
                        }
                    }
                }
                comboBoxEtudiant.DisplayMember = "Value";
                comboBoxEtudiant.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des étudiants: " + ex.Message);
            }
        }

        private void GenererPDF_Click(object sender, EventArgs e)
        {
            if (comboBoxEtudiant.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.");
                return;
            }

            var selectedStudent = (KeyValuePair<int, string>)comboBoxEtudiant.SelectedItem;
            int studentId = selectedStudent.Key;
            string studentName = selectedStudent.Value;

            DataTable dt = RecupererReleveEtudiant(studentId);
            if (dt.Rows.Count > 0)
            {
                ExporterPDF(dt, studentName);
            }
            else
            {
                MessageBox.Show("Aucune donnée trouvée pour cet étudiant.");
            }
        }

        private void GenererEXEL_Click(object sender, EventArgs e)
        {
            if (comboBoxEtudiant.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant.");
                return;
            }

            var selectedStudent = (KeyValuePair<int, string>)comboBoxEtudiant.SelectedItem;
            int studentId = selectedStudent.Key;
            string studentName = selectedStudent.Value;

            DataTable dt = RecupererReleveEtudiant(studentId);
            if (dt.Rows.Count > 0)
            {
                ExporterExcel(dt, studentName);
            }
            else
            {
                MessageBox.Show("Aucune donnée trouvée pour cet étudiant.");
            }
        }

        private DataTable RecupererReleveEtudiant(int studentId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT m.NomMatiere, n.Notes, 
                               (SELECT NomClasse FROM Classes c WHERE c.Id = e.IdClasse) AS Classe,
                               AVG(n.Notes) OVER (PARTITION BY m.Id) AS Moyenne
                        FROM Etudiants e
                        INNER JOIN Notes n ON n.Etudiant_Id = e.id
                        INNER JOIN Matieres m ON m.Id = n.Matiere_Id
                        WHERE e.id = @studentId";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données: " + ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                MessageBox.Show($"Erreur SQL : {ex.Message}");
                System.Diagnostics.Debug.WriteLine("SQL Error: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("Stack Trace: " + ex.StackTrace);
            }
            return dt;
        }

        private void ExporterPDF(DataTable dt, string studentName)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Fichiers PDF (*.pdf)|*.pdf",
                    FileName = $"Releve_{studentName}.pdf"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document doc = new Document(PageSize.A4);
                        PdfWriter.GetInstance(doc, fs);
                        doc.Open();

                        doc.Add(new Paragraph($"Relevé de Notes de {studentName}\n\n") { Alignment = Element.ALIGN_CENTER });

                        PdfPTable table = new PdfPTable(dt.Columns.Count);
                        foreach (DataColumn column in dt.Columns)
                        {
                            table.AddCell(new Phrase(column.ColumnName));
                        }
                        double totalNotes = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            foreach (var cell in row.ItemArray)
                            {
                                table.AddCell(new Phrase(cell.ToString()));
                            }
                            totalNotes += Convert.ToDouble(row["Notes"]);
                        }
                        doc.Add(table);

                        double moyenne = totalNotes / dt.Rows.Count;
                        doc.Add(new Paragraph($"\nMoyenne générale: {moyenne:F2}") { Alignment = Element.ALIGN_RIGHT });

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

        private void ExporterExcel(DataTable dt, string studentName)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Fichiers Excel (*.xlsx)|*.xlsx",
                    FileName = $"Releve_{studentName}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"Relevé de Notes {studentName}");

                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dt.Columns[i].ColumnName;
                        }

                        for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                        {
                            for (int colIndex = 0; colIndex < dt.Columns.Count; colIndex++)
                            {
                                worksheet.Cells[rowIndex + 2, colIndex + 1].Value = dt.Rows[rowIndex][colIndex].ToString();
                            }
                        }

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
    }
}
