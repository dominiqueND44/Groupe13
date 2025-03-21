using System;
using System.Linq;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class AjoutMatieresCoursForm : Form
    {
        private int selectedCoursId;
        private int selectedMatiereId;

        public AjoutMatieresCoursForm()
        {
            InitializeComponent();
            this.Load += AjoutMatieresCoursForm_Load;
            dataGridMatCours.CellClick += DataGridMatCours_CellClick; // Attacher l'événement CellClick
        }

        // Méthode pour actualiser le DataGridView avec les associations matières-cours
        private void actualize()
        {
            using (var db = new DBGestionContext())
            {
                dataGridMatCours.DataSource = db.CoursMatieres
                    .Select(cm => new
                    {
                        cm.IdCours,           // ID du Cours
                        cm.IdMatiere,         // ID de la Matière
                        Cours = cm.Cours.NomCours,  // Nom du Cours
                        Matiere = cm.Matiere.NomMatiere // Nom de la Matière
                    })
                    .ToList();
            }
        }

        // Méthode pour ajouter une nouvelle association matière-cours
        private void AjoutMatCours_Click(object sender, EventArgs e)
        {
            if (comboBoxMatiere.SelectedItem == null || comboBoxCours.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une matière et un cours !");
                return;
            }

            using (var db = new DBGestionContext())
            {
                var matiereId = (int)comboBoxMatiere.SelectedValue;
                var coursId = (int)comboBoxCours.SelectedValue;

                // Vérifier si l'association existe déjà
                if (db.CoursMatieres.Any(cm => cm.IdMatiere == matiereId && cm.IdCours == coursId))
                {
                    MessageBox.Show("Cette matière est déjà associée à ce cours !");
                    return;
                }

                // Créer une nouvelle association avec les clés étrangères
                CoursMatieres matiereCours = new CoursMatieres
                {
                    IdMatiere = matiereId,
                    IdCours = coursId
                };

                db.CoursMatieres.Add(matiereCours);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Association ajoutée avec succès !");
                    actualize();
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'association.");
                }
            }
        }

        // Méthode pour modifier une association existante
        private void ModifierMatCours_Click(object sender, EventArgs e)
        {
            if (selectedCoursId == 0 && selectedMatiereId == 0)
            {
                MessageBox.Show("Veuillez sélectionner une association !");
                return;
            }

            if (comboBoxMatiere.SelectedItem == null || comboBoxCours.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une matière et un cours !");
                return;
            }

            using (var db = new DBGestionContext())
            {
                var matiereCours = db.CoursMatieres
                                      .FirstOrDefault(cm => cm.IdCours == selectedCoursId && cm.IdMatiere == selectedMatiereId);

                if (matiereCours != null)
                {
                    matiereCours.IdMatiere = (int)comboBoxMatiere.SelectedValue;
                    matiereCours.IdCours = (int)comboBoxCours.SelectedValue;

                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Association modifiée avec succès !");
                        actualize();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification.");
                    }
                }
            }
        }

        // Méthode pour supprimer une association
        private void SupprimerMatCours_Click(object sender, EventArgs e)
        {
            if (selectedCoursId == 0 || selectedMatiereId == 0)
            {
                MessageBox.Show("Veuillez sélectionner une association !");
                return;
            }

            var confirmResult = MessageBox.Show("Voulez-vous vraiment supprimer cette association ?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new DBGestionContext())
                {
                    var matiereCours = db.CoursMatieres
                        .FirstOrDefault(cm => cm.IdCours == selectedCoursId && cm.IdMatiere == selectedMatiereId);

                    if (matiereCours != null)
                    {
                        db.CoursMatieres.Remove(matiereCours);
                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Association supprimée avec succès !");
                            actualize();
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("L'association n'a pas été trouvée.");
                    }
                }
            }
        }

        // Gestion du clic sur une cellule du DataGridView
        private void DataGridMatCours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Récupérer les Ids du Cours et de la Matière à partir des cellules correspondantes
                selectedCoursId = Convert.ToInt32(dataGridMatCours.Rows[e.RowIndex].Cells["IdCours"].Value);
                selectedMatiereId = Convert.ToInt32(dataGridMatCours.Rows[e.RowIndex].Cells["IdMatiere"].Value);

                // Mettre à jour les ComboBox avec les IDs sélectionnés
                comboBoxMatiere.SelectedValue = selectedMatiereId;
                comboBoxCours.SelectedValue = selectedCoursId;

                // Activer les boutons de modification et suppression
                ModifierMatCours.Enabled = true;
                SupprimerMatCours.Enabled = true;
                AjoutMatCours.Enabled = false;
            }
        }

        // Méthode pour vider les champs et réinitialiser les sélections
        private void ViderChamps_Click(object sender, EventArgs e)
        {
            comboBoxMatiere.SelectedIndex = -1;
            comboBoxCours.SelectedIndex = -1;
            selectedCoursId = 0;
            selectedMatiereId = 0;
            AjoutMatCours.Enabled = true;
        }

        // Méthode pour fermer la fenêtre
        private void FermerFenetre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Méthode pour charger les données initiales dans les ComboBox et actualiser le DataGridView
        private void AjoutMatieresCoursForm_Load(object sender, EventArgs e)
        {
            // Charger les combobox avec les matières et les cours
            using (var db = new DBGestionContext())
            {
                comboBoxMatiere.DataSource = db.Matieres.ToList();
                comboBoxMatiere.DisplayMember = "NomMatiere";
                comboBoxMatiere.ValueMember = "Id";

                comboBoxCours.DataSource = db.Cours.ToList();
                comboBoxCours.DisplayMember = "NomCours";
                comboBoxCours.ValueMember = "Id";
            }

            actualize(); // Actualiser le DataGridView
        }
    }
}
