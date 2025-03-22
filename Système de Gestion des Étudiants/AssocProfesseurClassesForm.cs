using System.Linq;
using System.Windows.Forms;
using System;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class AssocProfesseurClassesForm : Form
    {
        public AssocProfesseurClassesForm()
        {
            InitializeComponent();
            this.Load += AssocProfesseurClassesForm_Load;
            dataGridProfClasse.CellClick += dataGridProfClasse_CellContentClick; // Attachement de l'événement CellClick
        }


        // Méthode pour charger les professeurs et les classes dans les ComboBox
        private void AssocProfesseurClassesForm_Load(object sender, EventArgs e)
        {
            using (var db = new DBGestionContext())
            {
                // Charger les professeurs dans le comboBox
                comboBoxProfesseur.DataSource = db.Professeurs
                    .Select(p => new { p.Id, NomComplet = p.Nom + " " + p.Prenom })
                    .ToList();
                comboBoxProfesseur.DisplayMember = "NomComplet";
                comboBoxProfesseur.ValueMember = "Id";

                // Charger les classes dans le comboBox
                comboBoxClasse.DataSource = db.Classes
                    .Select(c => new { c.Id, c.NomClasse })
                    .ToList();
                comboBoxClasse.DisplayMember = "NomClasse";
                comboBoxClasse.ValueMember = "Id";
            }

            // Mettre à jour la liste des associations dans le DataGridView
            actualize();
        }


        // Méthode pour ajouter une association entre professeur et classe
        private void AjoutAssocProf_Click(object sender, EventArgs e)
        {
            int professeurId = Convert.ToInt32(comboBoxProfesseur.SelectedValue);
            int classeId = Convert.ToInt32(comboBoxClasse.SelectedValue);

            using (var db = new DBGestionContext())
            {
                // Vérifier si l'association existe déjà
                bool exists = db.ProfesseursClasses.Any(pc => pc.IdProfesseur == professeurId && pc.IdClasse == classeId);
                if (exists)
                {
                    MessageBox.Show("Cette association existe déjà.");
                    return;
                }

                // Ajouter l'association dans la table ProfesseursClasses
                var assoc = new ProfesseursClasses
                {
                    IdProfesseur = professeurId,
                    IdClasse = classeId
                };

                db.ProfesseursClasses.Add(assoc);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Association ajoutée avec succès.");
                    actualize(); // Mettre à jour la liste des associations
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'association.");
                }
            }
        }

        // Méthode pour actualiser la liste des associations dans le DataGridView
        private void actualize()
        {
            using (var db = new DBGestionContext())
            {
                var data = db.ProfesseursClasses
                    .Select(pc => new
                    {
                        IdProfesseur = pc.IdProfesseur,
                        Professeur = pc.Professeur.Nom + " " + pc.Professeur.Prenom,
                        IdClasse = pc.IdClasse,
                        Classe = pc.Classe.NomClasse
                    })
                    .ToList();

                dataGridProfClasse.DataSource = data;

                // S'assurer que les colonnes ont les bons titres
                dataGridProfClasse.Columns["IdProfesseur"].HeaderText = "ID Professeur";
                dataGridProfClasse.Columns["Professeur"].HeaderText = "Nom du Professeur";
                dataGridProfClasse.Columns["IdClasse"].HeaderText = "ID Classe";
                dataGridProfClasse.Columns["Classe"].HeaderText = "Nom de la Classe";
            }
        }

        // Méthode pour modifier une association existante
        // Méthode pour modifier une association existante
        private void ModifierAssocProf_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dataGridProfClasse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une association à modifier.");
                return;
            }

            // Sélectionner la ligne
            var selectedRow = dataGridProfClasse.SelectedRows[0];
            int professeurId = Convert.ToInt32(selectedRow.Cells["IdProfesseur"].Value);
            int classeId = Convert.ToInt32(selectedRow.Cells["IdClasse"].Value);

            // Récupérer les nouvelles valeurs après modification dans les ComboBox
            int newProfesseurId = Convert.ToInt32(comboBoxProfesseur.SelectedValue);
            int newClasseId = Convert.ToInt32(comboBoxClasse.SelectedValue);

            // Vérifier si les nouvelles valeurs sont différentes de l'ancienne association
            if (newProfesseurId == professeurId && newClasseId == classeId)
            {
                MessageBox.Show("Les valeurs n'ont pas été modifiées.");
                return;
            }

            // Vérifier si une autre association existe déjà avec les nouvelles valeurs
            using (var db = new DBGestionContext())
            {
                bool exists = db.ProfesseursClasses.Any(pc => pc.IdProfesseur == newProfesseurId && pc.IdClasse == newClasseId);
                if (exists)
                {
                    MessageBox.Show("Cette association existe déjà.");
                    return;
                }

                // Mettre à jour l'association dans la base de données
                var assoc = db.ProfesseursClasses
                    .FirstOrDefault(pc => pc.IdProfesseur == professeurId && pc.IdClasse == classeId);

                if (assoc != null)
                {
                    // Mettre à jour l'association avec les nouvelles valeurs
                    assoc.IdProfesseur = newProfesseurId;
                    assoc.IdClasse = newClasseId;

                    try
                    {
                        // Sauvegarder les modifications dans la base de données
                        db.SaveChanges();
                        MessageBox.Show("Association modifiée avec succès.");
                        actualize(); // Mettre à jour la liste des associations
                    }
                    catch (Exception ex)
                    {
                        // Si une erreur se produit, afficher un message d'erreur
                        MessageBox.Show($"Erreur lors de la modification de l'association : {ex.Message}");
                    }
                }
                else
                {
                    // Si l'association à modifier n'existe pas
                    MessageBox.Show("L'association à modifier n'existe pas.");
                }
            }
        }



        // Méthode pour supprimer une association
        // Méthode pour supprimer une association
        private void SupprimerAssocProf_Click(object sender, EventArgs e)
        {
            if (dataGridProfClasse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une association à supprimer.");
                return;
            }

            var selectedRow = dataGridProfClasse.SelectedRows[0];
            int professeurId = Convert.ToInt32(selectedRow.Cells["IdProfesseur"].Value);
            int classeId = Convert.ToInt32(selectedRow.Cells["IdClasse"].Value);

            string professeurNom = selectedRow.Cells["Professeur"].Value.ToString();
            string classeNom = selectedRow.Cells["Classe"].Value.ToString();

            var confirmResult = MessageBox.Show($"Voulez-vous vraiment supprimer l'association entre {professeurNom} et {classeNom} ?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new DBGestionContext())
                {
                    var assoc = db.ProfesseursClasses
                        .FirstOrDefault(pc => pc.IdProfesseur == professeurId && pc.IdClasse == classeId);

                    if (assoc != null)
                    {
                        db.ProfesseursClasses.Remove(assoc);
                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Association supprimée avec succès.");
                            actualize(); // Mettre à jour la liste des associations
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'association à supprimer n'existe pas.");
                    }
                }
            }
        }


        // Méthode pour gérer la sélection dans le DataGridView
        // Méthode pour gérer la sélection dans le DataGridView
        private void dataGridProfClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si l'index de la ligne est valide
            if (e.RowIndex >= 0)
            {
                // Sélectionner la ligne cliquée
                dataGridProfClasse.ClearSelection(); // D'abord, désélectionner toutes les lignes
                dataGridProfClasse.Rows[e.RowIndex].Selected = true; // Sélectionner la ligne cliquée

                // Récupérer les valeurs de la ligne sélectionnée
                var row = dataGridProfClasse.Rows[e.RowIndex];
                int professeurId = Convert.ToInt32(row.Cells["IdProfesseur"].Value);
                int classeId = Convert.ToInt32(row.Cells["IdClasse"].Value);

                // Mettre à jour les ComboBox avec les valeurs sélectionnées
                comboBoxProfesseur.SelectedValue = professeurId;
                comboBoxClasse.SelectedValue = classeId;
            }
        }





        // Méthode qui gère le clic sur le label (pour l'exemple, vous pouvez personnaliser cette méthode)
        private void label5_Click(object sender, EventArgs e)
        {
            // Vous pouvez ajouter une logique ici si nécessaire
        }
    }
}
