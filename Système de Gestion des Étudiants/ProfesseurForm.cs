using System;
using System.Linq;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class ProfesseurForm : Form
    {
        private int selectedProfesseurId; // Stocke l'ID du professeur sélectionné

        public ProfesseurForm()
        {
            InitializeComponent();
            this.Load += FormProfesseur_Load;
            dataGridProfesseur.CellClick += DataGridProfesseur_CellClick; // Attacher l'événement CellClick pour la sélection dans le DataGridView
            ModifierProfesseur.Enabled = false; // Désactiver le bouton "Modifier" au démarrage
            SupprimerProfesseur.Enabled = false; // Désactiver le bouton "Supprimer" au démarrage
        }

        // Méthode pour actualiser la liste des professeurs dans le DataGridView
        public void actualize()
        {
            using (var db = new DBGestionContext())
            {
                dataGridProfesseur.DataSource = db.Professeurs
                    .Select(p => new
                    {
                        ID = p.Id,
                        Nom = p.Nom,
                        Prenom = p.Prenom,
                        Email = p.Email,
                        Telephone = p.Telephone
                    })
                    .ToList();

                // Rendre la colonne ID visible
                dataGridProfesseur.Columns["ID"].Visible = true;
            }
        }

        // Méthode appelée lors du chargement de la fenêtre
        private void FormProfesseur_Load(object sender, EventArgs e)
        {
            textBoxTelprof.Text = "+221"; // Initialiser le champ de téléphone avec le code du Sénégal
            textBoxTelprof.SelectionStart = textBoxTelprof.Text.Length; // Placer le curseur à la fin
            actualize(); // Mettre à jour la liste des professeurs
        }

        // Méthode pour ajouter un nouveau professeur
        private void AjoutProfesseur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomprof.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrenomprof.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelprof.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmailprof.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires !");
                return;
            }

            // Vérification du format du numéro de téléphone
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxTelprof.Text, @"^\+221[0-9]{9}$"))
            {
                MessageBox.Show("Veuillez entrer un numéro valide avec 9 chiffres après +221.");
                return;
            }

            // Vérification du format de l'email
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEmailprof.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Veuillez entrer un email valide.");
                return;
            }

            using (var db = new DBGestionContext())
            {
                // Vérifier si l'email est déjà utilisé
                if (db.Professeurs.Any(p => p.Email == textBoxEmailprof.Text))
                {
                    MessageBox.Show("Cet email est déjà utilisé !");
                    return;
                }

                Professeur professeur = new Professeur
                {
                    Nom = textBoxNomprof.Text,
                    Prenom = textBoxPrenomprof.Text,
                    Email = textBoxEmailprof.Text,
                    Telephone = textBoxTelprof.Text
                };

                db.Professeurs.Add(professeur); // Ajouter le professeur à la base de données
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Professeur ajouté avec succès !");
                    actualize(); // Mettre à jour la liste des professeurs
                    ResetFields(); // Réinitialiser les champs du formulaire
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du professeur.");
                }
            }
        }

        // Méthode appelée lorsqu'un professeur est sélectionné dans le DataGridView
        private void DataGridProfesseur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedProfesseurId = Convert.ToInt32(dataGridProfesseur.Rows[e.RowIndex].Cells["ID"].Value);
                textBoxNomprof.Text = dataGridProfesseur.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                textBoxPrenomprof.Text = dataGridProfesseur.Rows[e.RowIndex].Cells["Prenom"].Value.ToString();
                textBoxEmailprof.Text = dataGridProfesseur.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                textBoxTelprof.Text = dataGridProfesseur.Rows[e.RowIndex].Cells["Telephone"].Value.ToString();

                // Désactiver le bouton "Vider Champs" lorsque l'utilisateur est sélectionné
                ViderChamps.Enabled = false;
                ModifierProfesseur.Enabled = true; // Activer le bouton "Modifier"
                SupprimerProfesseur.Enabled = true; // Activer le bouton "Supprimer"
            }
        }

        // Méthode pour modifier un professeur sélectionné
        private void ModifierProfesseur_Click(object sender, EventArgs e)
        {
            if (selectedProfesseurId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un professeur !");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNomprof.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrenomprof.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelprof.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmailprof.Text))
            {
                MessageBox.Show("Tous les champs sont obligatoires !");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxTelprof.Text, @"^\+221[0-9]{9}$"))
            {
                MessageBox.Show("Veuillez entrer un numéro valide avec 9 chiffres après +221.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxEmailprof.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Veuillez entrer un email valide.");
                return;
            }

            using (var db = new DBGestionContext())
            {
                var professeur = db.Professeurs.Find(selectedProfesseurId);
                if (professeur != null)
                {
                    // Vérifier si l'email est déjà utilisé
                    if (db.Professeurs.Any(p => p.Email == textBoxEmailprof.Text && p.Id != selectedProfesseurId))
                    {
                        MessageBox.Show("Cet email est déjà utilisé !");
                        return;
                    }

                    professeur.Nom = textBoxNomprof.Text;
                    professeur.Prenom = textBoxPrenomprof.Text;
                    professeur.Email = textBoxEmailprof.Text;
                    professeur.Telephone = textBoxTelprof.Text;

                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Professeur modifié avec succès !");
                        actualize(); // Mettre à jour la liste des professeurs
                        ResetFields(); // Réinitialiser les champs
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification.");
                    }
                }
            }
        }

        // Méthode pour supprimer un professeur sélectionné
        private void SupprimerProfesseur_Click(object sender, EventArgs e)
        {
            if (selectedProfesseurId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un professeur !");
                return;
            }

            var confirmResult = MessageBox.Show("Voulez-vous vraiment supprimer ce professeur ?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new DBGestionContext())
                {
                    var professeur = db.Professeurs.Find(selectedProfesseurId);
                    if (professeur != null)
                    {
                        db.Professeurs.Remove(professeur);
                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Professeur supprimé avec succès !");
                            actualize(); // Mettre à jour la liste des professeurs
                            ResetFields(); // Réinitialiser les champs
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression.");
                        }
                    }
                }
            }
        }

        // Méthode pour réinitialiser les champs du formulaire
        private void ResetFields()
        {
            textBoxNomprof.Clear();
            textBoxPrenomprof.Clear();
            textBoxEmailprof.Clear();
            textBoxTelprof.Text = "+221";
            selectedProfesseurId = 0;
        }

        // Méthode pour vider les champs du formulaire
        private void ViderChamps_Click(object sender, EventArgs e)
        {
            // Réinitialiser les champs seulement si aucun professeur n'est sélectionné
            if (selectedProfesseurId == 0)
            {
                ResetFields();
            }
        }

        // Méthode pour fermer la fenêtre
        private void FermerFenetre_Click(object sender, EventArgs e)
        {
            this.Close(); // Fermer la fenêtre
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Association à matière
            AssocProfesseurMatieresForm assocProfesseurMatieresForm = new AssocProfesseurMatieresForm();
            assocProfesseurMatieresForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Association à classe
            AssocProfesseurClassesForm assocProfesseurClassesForm = new AssocProfesseurClassesForm();
            assocProfesseurClassesForm.Show();
        }
    }
}
