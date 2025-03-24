using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class UsersForm : Form
    {
        private int selectedUserId; // Stocke l'ID de l'utilisateur sélectionné

        public UsersForm()
        {
            InitializeComponent();
            this.Load += FormAjoutUtilisateur_Load;
            dataGridUser.CellClick += DataGridUser_CellClick; // Attacher l'événement CellClick pour la sélection dans le DataGridView
            ModifierUser.Enabled = false; // Désactiver le bouton "Modifier" au démarrage
        }

        // Méthode pour actualiser la liste des utilisateurs dans le DataGridView
        public void actualize()
        {
            using (var db = new DBGestionContext())
            {
                dataGridUser.DataSource = db.Utilisateurs
                    .Select(u => new
                    {
                        ID = u.Id,
                        NomUtilisateur = u.NomUtilisateur,
                        Role = u.Role,
                        Telephone = u.Telephone,
                        // Masquer le mot de passe en affichant '*********'
                        MotDePasse = "*********"
                    })
                    .ToList();

                // Rendre la colonne ID visible
                dataGridUser.Columns["ID"].Visible = true;
            }
        }

        // Méthode appelée lors du chargement de la fenêtre
        private void FormAjoutUtilisateur_Load(object sender, EventArgs e)
        {
            comboBoxRole.Items.AddRange(new string[] { "Administrateur", "Professeur", "Agent", "DE" });

            textBoxTelUser.Text = "+221"; // Initialiser le champ de téléphone avec le code du Sénégal
            textBoxTelUser.SelectionStart = textBoxTelUser.Text.Length; // Placer le curseur à la fin

            actualize(); // Mettre à jour la liste des utilisateurs
        }

        // Méthode pour ajouter un nouvel utilisateur
        private void AjoutProfesseur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomUser.Text) ||
                string.IsNullOrWhiteSpace(textBoxmdp.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelUser.Text) ||
                comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires !");
                return;
            }

            // Vérification du format du numéro de téléphone
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxTelUser.Text, @"^\+221[0-9]{9}$"))
            {
                MessageBox.Show("Veuillez entrer un numéro valide avec 9 chiffres après +221.");
                return;
            }

            using (var db = new DBGestionContext())
            {
                // Vérifier si le nom d'utilisateur est déjà pris
                if (db.Utilisateurs.Any(u => u.NomUtilisateur == textBoxNomUser.Text))
                {
                    MessageBox.Show("Ce nom d'utilisateur est déjà pris !");
                    return;
                }

                // Vérifier si le numéro de téléphone est déjà utilisé
                if (db.Utilisateurs.Any(u => u.Telephone == textBoxTelUser.Text))
                {
                    MessageBox.Show("Ce numéro de téléphone est déjà utilisé !");
                    return;
                }

                Utilisateur utilisateur = new Utilisateur
                {
                    NomUtilisateur = textBoxNomUser.Text,
                    MotDePasse = BCrypt.Net.BCrypt.HashPassword(textBoxmdp.Text), // Hachage du mot de passe
                    Role = comboBoxRole.SelectedItem.ToString(),
                    Telephone = textBoxTelUser.Text
                };

                db.Utilisateurs.Add(utilisateur); // Ajouter l'utilisateur à la base de données
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Utilisateur ajouté avec succès !");
                    actualize(); // Mettre à jour la liste des utilisateurs
                    ResetFields(); // Réinitialiser les champs du formulaire
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de l'utilisateur.");
                }
            }
        }

        // Méthode appelée lorsqu'un utilisateur est sélectionné dans le DataGridView
        private void DataGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedUserId = Convert.ToInt32(dataGridUser.Rows[e.RowIndex].Cells["ID"].Value);
                textBoxNomUser.Text = dataGridUser.Rows[e.RowIndex].Cells["NomUtilisateur"].Value.ToString();
                comboBoxRole.SelectedItem = dataGridUser.Rows[e.RowIndex].Cells["Role"].Value.ToString();
                textBoxTelUser.Text = dataGridUser.Rows[e.RowIndex].Cells["Telephone"].Value.ToString();

                // Masquer le mot de passe en affichant '*********'
                using (var db = new DBGestionContext())
                {
                    var utilisateur = db.Utilisateurs.Find(selectedUserId);
                    if (utilisateur != null)
                    {
                        textBoxmdp.Text = "*********"; // Afficher '*********' pour masquer le mot de passe
                    }
                }

                textBoxNomUser.Enabled = false; // Empêcher la modification du NomUtilisateur

                // Désactiver le bouton "Vider Champs" lorsque l'utilisateur est sélectionné
                ViderChamps.Enabled = false;
            }
        }

        // Méthode pour modifier un utilisateur sélectionné
        private void ModifierUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur !");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxmdp.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelUser.Text) ||
                comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Tous les champs sont obligatoires !");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxTelUser.Text, @"^\+221[0-9]{9}$"))
            {
                MessageBox.Show("Veuillez entrer un numéro valide avec 9 chiffres après +221.");
                return;
            }

            using (var db = new DBGestionContext())
            {
                var utilisateur = db.Utilisateurs.Find(selectedUserId);
                if (utilisateur != null)
                {
                    if (db.Utilisateurs.Any(u => u.Telephone == textBoxTelUser.Text && u.Id != selectedUserId))
                    {
                        MessageBox.Show("Ce numéro de téléphone est déjà utilisé !");
                        return;
                    }

                    utilisateur.Role = comboBoxRole.SelectedItem.ToString();
                    utilisateur.Telephone = textBoxTelUser.Text;

                    // Vérifier si le mot de passe a été modifié
                    if (textBoxmdp.Text != "*********") // Si le mot de passe a été modifié
                    {
                        utilisateur.MotDePasse = BCrypt.Net.BCrypt.HashPassword(textBoxmdp.Text); // Hachage du mot de passe
                    }

                    if (db.SaveChanges() > 0)
                    {
                        MessageBox.Show("Utilisateur modifié avec succès !");
                        actualize(); // Mettre à jour la liste des utilisateurs
                        ResetFields(); // Réinitialiser les champs
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la modification.");
                    }
                }
            }
        }

        // Méthode pour supprimer un utilisateur sélectionné
        private void SupprimerUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur !");
                return;
            }

            var confirmResult = MessageBox.Show("Voulez-vous vraiment supprimer cet utilisateur ?",
                                                "Confirmation",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new DBGestionContext())
                {
                    var utilisateur = db.Utilisateurs.Find(selectedUserId);
                    if (utilisateur != null)
                    {
                        db.Utilisateurs.Remove(utilisateur);
                        if (db.SaveChanges() > 0)
                        {
                            MessageBox.Show("Utilisateur supprimé avec succès !");
                            actualize(); // Mettre à jour la liste des utilisateurs
                            ResetFields(); // Réinitialiser les champs
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de la suppression.");
                        }
                    }
                }
            }
            else if (confirmResult == DialogResult.No)
            {
                MessageBox.Show("Opération annulée.");
            }
        }

        // Méthode pour réinitialiser les champs du formulaire
        private void ResetFields()
        {
            textBoxNomUser.Clear();
            textBoxmdp.Clear();
            textBoxTelUser.Text = "+221";
            comboBoxRole.SelectedIndex = -1;
            textBoxNomUser.Enabled = true;
            selectedUserId = 0;
        }

        // Méthode pour vider les champs du formulaire
        private void ViderChamps_Click(object sender, EventArgs e)
        {
            // Réinitialiser les champs seulement si aucun utilisateur n'est sélectionné
            if (selectedUserId == 0)
            {
                textBoxNomUser.Clear();
                textBoxmdp.Clear();
                textBoxTelUser.Text = "+221";
                comboBoxRole.SelectedIndex = -1;
                textBoxNomUser.Enabled = true;
                selectedUserId = 0;
            }
        }

        // Méthode pour fermer la fenêtre
        private void FermerFenetre_Click(object sender, EventArgs e)
        {
            this.Close(); // Fermer la fenêtre
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
             
        }
    }
}
