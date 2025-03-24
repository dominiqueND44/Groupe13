using System.Linq;
using System.Windows.Forms;
using System;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class AssociationCoursMatieresProfesseuràClasseForm : Form
    {
        public AssociationCoursMatieresProfesseuràClasseForm()
        {
            InitializeComponent();
            this.Load += AssociationCoursMatieresProfesseuràClasseForm_Load;
            dataGridCMPClasse.CellClick += dataGridAssociation_CellContentClick; // Attachement de l'événement CellClick
        }

        // Méthode pour charger les données dans les ComboBox
        private void AssociationCoursMatieresProfesseuràClasseForm_Load(object sender, EventArgs e)
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

                // Charger les cours dans le comboBox
                comboBoxCours.DataSource = db.Cours
                    .Select(c => new { c.Id, c.NomCours })
                    .ToList();
                comboBoxCours.DisplayMember = "NomCours";
                comboBoxCours.ValueMember = "Id";

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

        // Méthode pour ajouter une association entre cours, matière, professeur et classe
        private void AjoutPourClasse_Click(object sender, EventArgs e)
        {
            int professeurId = Convert.ToInt32(comboBoxProfesseur.SelectedValue);
            int matiereId = Convert.ToInt32(comboBoxMatiere.SelectedValue);
            int coursId = Convert.ToInt32(comboBoxCours.SelectedValue);
            int classeId = Convert.ToInt32(comboBoxClasse.SelectedValue);

            using (var db = new DBGestionContext())
            {
                // Vérifier si l'association existe déjà
                bool exists = db.CoursMatieresProfesseursClasses
                    .Any(cmpc => cmpc.IdProfesseur == professeurId && cmpc.IdMatiere == matiereId && cmpc.IdCours == coursId && cmpc.IdClasse == classeId);
                if (exists)
                {
                    MessageBox.Show("Cette association existe déjà.");
                    return;
                }

                // Ajouter l'association dans la table CoursMatieresProfesseursClasses
                var assoc = new CoursMatieresProfesseursClasses
                {
                    IdProfesseur = professeurId,
                    IdMatiere = matiereId,
                    IdCours = coursId,
                    IdClasse = classeId
                };

                db.CoursMatieresProfesseursClasses.Add(assoc);
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
                var data = db.CoursMatieresProfesseursClasses
                    .Select(cmpc => new
                    {
                        IdProfesseur = cmpc.IdProfesseur,
                        Professeur = cmpc.Professeur.Nom + " " + cmpc.Professeur.Prenom,
                        IdMatiere = cmpc.IdMatiere,
                        Matiere = cmpc.Matiere.NomMatiere,
                        IdCours = cmpc.IdCours,
                        Cours = cmpc.Cours.NomCours,
                        IdClasse = cmpc.IdClasse,
                        Classe = cmpc.Classe.NomClasse
                    })
                    .ToList();

                dataGridCMPClasse.DataSource = data;

                // S'assurer que les colonnes ont les bons titres
                dataGridCMPClasse.Columns["IdProfesseur"].HeaderText = "ID Professeur";
                dataGridCMPClasse.Columns["Professeur"].HeaderText = "Nom du Professeur";
                dataGridCMPClasse.Columns["IdMatiere"].HeaderText = "ID Matière";
                dataGridCMPClasse.Columns["Matiere"].HeaderText = "Nom de la Matière";
                dataGridCMPClasse.Columns["IdCours"].HeaderText = "ID Cours";
                dataGridCMPClasse.Columns["Cours"].HeaderText = "Nom du Cours";
                dataGridCMPClasse.Columns["IdClasse"].HeaderText = "ID Classe";
                dataGridCMPClasse.Columns["Classe"].HeaderText = "Nom de la Classe";
            }
        }

        // Méthode pour modifier une association existante
        private void ModifierPourClasse_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée
            if (dataGridCMPClasse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une association à modifier.");
                return;
            }

            // Sélectionner la ligne
            var selectedRow = dataGridCMPClasse.SelectedRows[0];
            int professeurId = Convert.ToInt32(selectedRow.Cells["IdProfesseur"].Value);
            int matiereId = Convert.ToInt32(selectedRow.Cells["IdMatiere"].Value);
            int coursId = Convert.ToInt32(selectedRow.Cells["IdCours"].Value);
            int classeId = Convert.ToInt32(selectedRow.Cells["IdClasse"].Value);

            // Récupérer les nouvelles valeurs après modification dans les ComboBox
            int newProfesseurId = Convert.ToInt32(comboBoxProfesseur.SelectedValue);
            int newMatiereId = Convert.ToInt32(comboBoxMatiere.SelectedValue);
            int newCoursId = Convert.ToInt32(comboBoxCours.SelectedValue);
            int newClasseId = Convert.ToInt32(comboBoxClasse.SelectedValue);

            // Vérifier si les nouvelles valeurs sont différentes de l'ancienne association
            if (newProfesseurId == professeurId && newMatiereId == matiereId && newCoursId == coursId && newClasseId == classeId)
            {
                MessageBox.Show("Les valeurs n'ont pas été modifiées.");
                return;
            }

            // Vérifier si une autre association existe déjà avec les nouvelles valeurs
            using (var db = new DBGestionContext())
            {
                bool exists = db.CoursMatieresProfesseursClasses.Any(cmpc => cmpc.IdProfesseur == newProfesseurId && cmpc.IdMatiere == newMatiereId && cmpc.IdCours == newCoursId && cmpc.IdClasse == newClasseId);
                if (exists)
                {
                    MessageBox.Show("Cette association existe déjà.");
                    return;
                }

                // Mettre à jour l'association dans la base de données
                var assoc = db.CoursMatieresProfesseursClasses
                    .FirstOrDefault(cmpc => cmpc.IdProfesseur == professeurId && cmpc.IdMatiere == matiereId && cmpc.IdCours == coursId && cmpc.IdClasse == classeId);

                if (assoc != null)
                {
                    // Mettre à jour l'association avec les nouvelles valeurs
                    assoc.IdProfesseur = newProfesseurId;
                    assoc.IdMatiere = newMatiereId;
                    assoc.IdCours = newCoursId;
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
        private void SupprimerPourClasse_Click(object sender, EventArgs e)
        {
            if (dataGridCMPClasse.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une association à supprimer.");
                return;
            }

            var selectedRow = dataGridCMPClasse.SelectedRows[0];
            int professeurId = Convert.ToInt32(selectedRow.Cells["IdProfesseur"].Value);
            int matiereId = Convert.ToInt32(selectedRow.Cells["IdMatiere"].Value);
            int coursId = Convert.ToInt32(selectedRow.Cells["IdCours"].Value);
            int classeId = Convert.ToInt32(selectedRow.Cells["IdClasse"].Value);

            string professeurNom = selectedRow.Cells["Professeur"].Value.ToString();
            string matiereNom = selectedRow.Cells["Matiere"].Value.ToString();
            string coursNom = selectedRow.Cells["Cours"].Value.ToString();
            string classeNom = selectedRow.Cells["Classe"].Value.ToString();

            var confirmResult = MessageBox.Show($"Voulez-vous vraiment supprimer l'association entre {professeurNom}, {matiereNom}, {coursNom} et {classeNom} ?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new DBGestionContext())
                {
                    var assoc = db.CoursMatieresProfesseursClasses
                        .FirstOrDefault(cmpc => cmpc.IdProfesseur == professeurId && cmpc.IdMatiere == matiereId && cmpc.IdCours == coursId && cmpc.IdClasse == classeId);

                    if (assoc != null)
                    {
                        db.CoursMatieresProfesseursClasses.Remove(assoc);
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
        private void dataGridAssociation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifier si l'index de la ligne est valide
            if (e.RowIndex >= 0)
            {
                // Sélectionner la ligne cliquée
                dataGridCMPClasse.ClearSelection(); // D'abord, désélectionner toutes les lignes
                dataGridCMPClasse.Rows[e.RowIndex].Selected = true; // Sélectionner la ligne cliquée

                // Récupérer les valeurs de la ligne sélectionnée
                var row = dataGridCMPClasse.Rows[e.RowIndex];
                int professeurId = Convert.ToInt32(row.Cells["IdProfesseur"].Value);
                int matiereId = Convert.ToInt32(row.Cells["IdMatiere"].Value);
                int coursId = Convert.ToInt32(row.Cells["IdCours"].Value);
                int classeId = Convert.ToInt32(row.Cells["IdClasse"].Value);

                // Mettre à jour les ComboBox avec les valeurs sélectionnées
                comboBoxProfesseur.SelectedValue = professeurId;
                comboBoxMatiere.SelectedValue = matiereId;
                comboBoxCours.SelectedValue = coursId;
                comboBoxClasse.SelectedValue = classeId;
            }
        }
    }
}
