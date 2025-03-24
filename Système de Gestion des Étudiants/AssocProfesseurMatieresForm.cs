using System.Linq;
using System.Windows.Forms;
using System;
using System.Data.Entity.Infrastructure;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class AssocProfesseurMatieresForm : Form
    {
        public AssocProfesseurMatieresForm()
        {
            InitializeComponent();
            this.Load += AssocProfesseurMatieresForm_Load;
            dataGridMatiereProf.CellClick += dataGridClasse_CellContentClick; // Attachement de l'événement CellClick
        }
            
        // Méthode pour charger les professeurs et les matières dans les ComboBox
        private void AssocProfesseurMatieresForm_Load(object sender, EventArgs e)
        {
            using (var db = new DBGestionContext())
            {
                // Charger les professeurs dans le comboBox
                comboBoxProfesseur.DataSource = db.Professeurs
                    .Select(p => new { p.Id, NomComplet = p.Nom + " " + p.Prenom })
                    .ToList();
                comboBoxProfesseur.DisplayMember = "NomComplet";
                comboBoxProfesseur.ValueMember = "Id";

                // Charger les matières dans le comboBox
                comboBoxMatiere.DataSource = db.Matieres
                    .Select(m => new { m.Id, m.NomMatiere })
                    .ToList();
                comboBoxMatiere.DisplayMember = "NomMatiere";
                comboBoxMatiere.ValueMember = "Id";
            }

            // Mettre à jour la liste des associations dans le DataGridView
            actualize();
        }

        // Méthode pour ajouter une association entre professeur et matière
        private void AjoutMatiereProf_Click(object sender, EventArgs e)
        {
            int professeurId = Convert.ToInt32(comboBoxProfesseur.SelectedValue);
            int matiereId = Convert.ToInt32(comboBoxMatiere.SelectedValue);

            using (var db = new DBGestionContext())
            {
                // Vérifier si l'association existe déjà
                bool exists = db.ProfesseursMatieres.Any(pm => pm.IdProfesseur == professeurId && pm.IdMatiere == matiereId);
                if (exists)
                {
                    MessageBox.Show("Cette association existe déjà.");
                    return;
                }

                // Ajouter l'association dans la table ProfesseursMatieres
                var assoc = new ProfesseursMatieres
                {
                    IdProfesseur = professeurId,
                    IdMatiere = matiereId
                };

                db.ProfesseursMatieres.Add(assoc);
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
                var data = db.ProfesseursMatieres
                    .Select(pm => new
                    {
                        IdProfesseur = pm.IdProfesseur,
                        Professeur = pm.Professeur.Nom + " " + pm.Professeur.Prenom,
                        IdMatiere = pm.IdMatiere,
                        Matiere = pm.Matiere.NomMatiere
                    })
                    .ToList();

                dataGridMatiereProf.DataSource = data;

                // S'assurer que les colonnes ont les bons titres
                dataGridMatiereProf.Columns["IdProfesseur"].HeaderText = "ID Professeur";
                dataGridMatiereProf.Columns["Professeur"].HeaderText = "Nom du Professeur";
                dataGridMatiereProf.Columns["IdMatiere"].HeaderText = "ID Matière";
                dataGridMatiereProf.Columns["Matiere"].HeaderText = "Nom de la Matière";
            }
        }

        // Méthode pour modifier une association existante
        private void ModifierMatiereProf_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dataGridMatiereProf.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une association à modifier.");
                return;
            }

            // Sélectionner la ligne
            var selectedRow = dataGridMatiereProf.SelectedRows[0];
            int professeurId = Convert.ToInt32(selectedRow.Cells["IdProfesseur"].Value);
            int matiereId = Convert.ToInt32(selectedRow.Cells["IdMatiere"].Value);

            // Récupérer les nouvelles valeurs après modification dans les ComboBox
            if (comboBoxProfesseur.SelectedValue == null || comboBoxMatiere.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un professeur et une matière valides.");
                return;
            }

            int newProfesseurId = Convert.ToInt32(comboBoxProfesseur.SelectedValue);
            int newMatiereId = Convert.ToInt32(comboBoxMatiere.SelectedValue);

            // Vérifier si les nouvelles valeurs sont différentes de l'ancienne association
            if (newProfesseurId == professeurId && newMatiereId == matiereId)
            {
                MessageBox.Show("Les valeurs n'ont pas été modifiées.");
                return;
            }

            // Vérifier si une autre association existe déjà avec les nouvelles valeurs
            using (var db = new DBGestionContext())
            {
                bool exists = db.ProfesseursMatieres.Any(pm => pm.IdProfesseur == newProfesseurId && pm.IdMatiere == newMatiereId);
                if (exists)
                {
                    MessageBox.Show("Cette association existe déjà.");
                    return;
                }

                // Créer un nouvel enregistrement avec les nouvelles valeurs
                var newAssoc = new ProfesseursMatieres
                {
                    IdProfesseur = newProfesseurId,
                    IdMatiere = newMatiereId
                };

                try
                {
                    // Ajouter le nouvel enregistrement dans la base de données
                    db.ProfesseursMatieres.Add(newAssoc);

                    // Supprimer l'ancien enregistrement
                    var oldAssoc = db.ProfesseursMatieres
                        .FirstOrDefault(pm => pm.IdProfesseur == professeurId && pm.IdMatiere == matiereId);
                    if (oldAssoc != null)
                    {
                        db.ProfesseursMatieres.Remove(oldAssoc);
                    }

                    // Sauvegarder les modifications dans la base de données
                    db.SaveChanges();

                    MessageBox.Show("Association modifiée avec succès.");
                    actualize(); // Mettre à jour la liste des associations
                }
                catch (Exception ex)
                {
                    // Si une erreur se produit, afficher un message d'erreur
                    MessageBox.Show($"Erreur lors de la modification de l'association : {ex.Message}");
                    System.Diagnostics.Debug.WriteLine(ex.StackTrace);
                }
            }
        }



        // Méthode pour supprimer une association
        private void SupprimerMatiereProf_Click(object sender, EventArgs e)
        {
            if (dataGridMatiereProf.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une association à supprimer.");
                return;
            }

            var selectedRow = dataGridMatiereProf.SelectedRows[0];
            int professeurId = Convert.ToInt32(selectedRow.Cells["IdProfesseur"].Value);
            int matiereId = Convert.ToInt32(selectedRow.Cells["IdMatiere"].Value);

            string professeurNom = selectedRow.Cells["Professeur"].Value.ToString();
            string matiereNom = selectedRow.Cells["Matiere"].Value.ToString();

            var confirmResult = MessageBox.Show($"Voulez-vous vraiment supprimer l'association entre {professeurNom} et {matiereNom} ?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new DBGestionContext())
                {
                    var assoc = db.ProfesseursMatieres
                        .FirstOrDefault(pm => pm.IdProfesseur == professeurId && pm.IdMatiere == matiereId);

                    if (assoc != null)
                    {
                        db.ProfesseursMatieres.Remove(assoc);
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
        private void dataGridClasse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si l'index de la ligne est valide
            if (e.RowIndex >= 0)
            {
                // Sélectionner la ligne cliquée
                dataGridMatiereProf.ClearSelection(); // D'abord, désélectionner toutes les lignes
                dataGridMatiereProf.Rows[e.RowIndex].Selected = true; // Sélectionner la ligne cliquée

                // Récupérer les valeurs de la ligne sélectionnée
                var row = dataGridMatiereProf.Rows[e.RowIndex];
                int professeurId = Convert.ToInt32(row.Cells["IdProfesseur"].Value);
                int matiereId = Convert.ToInt32(row.Cells["IdMatiere"].Value);

                // Mettre à jour les ComboBox avec les valeurs sélectionnées
                comboBoxProfesseur.SelectedValue = professeurId;
                comboBoxMatiere.SelectedValue = matiereId;
            }
        }

    }
}
