using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class EtudiantsForm: Form
    {
        private DBGestionContext _context;
        public EtudiantsForm()
        {
            InitializeComponent();
            _context = new DBGestionContext();

            // Empêcher la modification directe dans le DataGridView
            dataGridEtudiant.ReadOnly = true;
            // Empêcher l'ajout et la suppression de lignes
            dataGridEtudiant.AllowUserToAddRows = false;
            dataGridEtudiant.AllowUserToDeleteRows = false;
            // Rendre le champ matricule en lecture seule
            txtmatricule.ReadOnly = true;
            Refresh();
        }

        private void LoadClasses()
        {
            var classes = _context.Classes.ToList();

            // Ajouter une option vide dans cmbClasse pour forcer l'utilisateur à sélectionner une classe
            classes.Insert(0, new Classe { Id = 0, NomClasse = "Sélectionnez une classe" });
            cmbclasse.DataSource = classes;
            cmbclasse.DisplayMember = "NomClasse";
            cmbclasse.ValueMember = "Id";
            // Par défaut, la première option est la valeur "Sélectionnez une classe"
            cmbclasse.SelectedIndex = 0;
        }


        private void EtudiantsForm_Load(object sender, EventArgs e)
        {
            using (var db = new DBGestionContext())
            {
                cmbclasse.DataSource = db.Classes.ToList();
                cmbclasse.DisplayMember = "NomClasse";
                cmbclasse.ValueMember = "Id";
            }
            // Initialisation du ComboBox avec les valeurs possibles (Masculin/Féminin)
            cmbsexe.Items.Clear();
            cmbsexe.Items.Add("M"); // M pour Masculin
            cmbsexe.Items.Add("F"); // F pour Féminin
            // Ajouter une option vide pour obliger l'utilisateur à faire un choix
            cmbsexe.Items.Insert(0, "Sélectionnez le sexe");
            cmbsexe.SelectedIndex = 0; // La première option est vide (ou explicative)

            // Charger les classes depuis la base de données dans cmbClasse
            LoadClasses();
            Refresh();
        }

        private void AjoutEtudiant_Click(object sender, EventArgs e)
        {
            try
            {
                // Génération automatique du matricule
                string matricule = "ET" + DateTime.Now.ToString("yyMMddHHmmss");
                // Validation du nom
                if (!ValiderNomPrenom(txtnom.Text))
                {
                    MessageBox.Show("Le nom ne doit contenir que des lettres et des espaces.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validation du prenom
                if (!ValiderNomPrenom(txtprenom.Text))
                {
                    MessageBox.Show("Le prenom ne doit contenir que des lettres et des espaces.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validation du mail 
                if (!ValiderEmail(txtemail.Text))
                {
                    MessageBox.Show("Adresse e-mail invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Validation du téléphone 
                if (!ValiderNumero(txttelephone.Text))
                {
                    MessageBox.Show("Le numéro de téléphone doit être un numéro valide (ex: 7XXXXXXXX ou +2217XXXXXXXX).",
                                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Vérifier l'unicité du matricule
                if (_context.Etudiants.Any(Etudiant => Etudiant.Matricule == matricule))
                {
                    MessageBox.Show("Un étudiant avec ce matricule existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Vérifier l'unicité du mail
                if (_context.Etudiants.Any(Etudiant => Etudiant.Email == txtemail.Text))
                {
                    MessageBox.Show("Un étudiant avec cet email existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Vérifier l'unicité du téléphone
                if (_context.Etudiants.Any(Etudiant => Etudiant.Telephone == txttelephone.Text))
                {
                    MessageBox.Show("Un étudiant avec ce numéro de téléphone existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Récupération de la valeur sélectionnée dans le ComboBox pour le sexe
                string sexe = cmbsexe.SelectedItem.ToString();

                // Récupération de l'ID de la classe sélectionnée
                int classeId = (int)cmbclasse.SelectedValue;

                // Création d'un nouvel étudiant
                var etudiant = new Etudiant
                {
                    Nom = txtnom.Text,
                    Prenom = txtprenom.Text,
                    Matricule = matricule,
                    DateNaissance = dtpdatenaissance.Value,
                    sexe = cmbsexe.SelectedItem.ToString(),
                    Adresse = txtadresse.Text,
                    Telephone = txttelephone.Text,
                    Email = txtemail.Text,
                    IdClasse = classeId
                };
                // Ajout de l'étudiant à la base de données
                _context.Etudiants.Add(etudiant);
                _context.SaveChanges();
                // Rafraîchir la liste des étudiants
                Refresh();
                // Vider les champs après l'ajout
                ClearFields();
                MessageBox.Show("Étudiant ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        private void ClearFields()
        {
            // Réinitialiser les champs de saisie
            txtmatricule.Text = string.Empty;
            txtnom.Text = string.Empty;
            txtprenom.Text = string.Empty;
            txtadresse.Text = string.Empty;
            txttelephone.Text = string.Empty;
            txtemail.Text = string.Empty;
            // Réinitialiser les ComboBox
            cmbsexe.SelectedIndex = 0; // Sélectionner l'option vide
            cmbclasse.SelectedIndex = 0; // Sélectionner l'option vide
        }

        private bool ValiderNumero(string text)
        {
            throw new NotImplementedException();
        }

        private bool ValiderEmail(string adresse)
        {
            // Supprimer les espaces au début et à la fin
            adresse = adresse.Trim();
            return true;
        }

        private bool ValiderNomPrenom(string text)
        {
            // autoriser uniquement les lettres et les espaces
            string pattern = @"^[a,zA,Z]+(?:[\s][a,zA,Z]+)*$";
            // Supprimer les espaces en début et en fin
            text = text.Trim();
            // Vérifier si la longueur est supérieure ou égale à 2 caractères
            if (text.Length < 2)
            {
                return false;
            }
            return true;
        }

        public void refresh()
        {
            // Charger les étudiants avec le nom de la classe
            var etudiants = _context.Etudiants
                .Select(e => new
                {
                    e.Id,
                    e.Matricule,
                    e.Nom,
                    e.Prenom,
                    e.DateNaissance,
                    e.sexe,
                    e.Adresse,
                    e.Telephone,
                    e.Email,
                    ClasseNom = e.Classe.NomClasse,  // Récupérer le nom de la classe
                    e.IdClasse  
                })
                .ToList();
            dataGridEtudiant.DataSource = null;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbclasse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModifierEtudiant_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridEtudiant.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(txtnom.Text) || string.IsNullOrWhiteSpace(txtprenom.Text) || cmbsexe.SelectedIndex == 0 || cmbclasse.SelectedIndex == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validation du nom
            if (!ValiderNomPrenom(txtnom.Text))
            {
                MessageBox.Show("Le nom ne doit contenir que des lettres et des espaces.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validation du prenom
            if (!ValiderNomPrenom(txtprenom.Text))
            {
                MessageBox.Show("Le prenom ne doit contenir que des lettres et des espaces.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validation de l'email
            if (!ValiderEmail(txtemail.Text))
            {
                MessageBox.Show("L'email n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValiderNumero(txttelephone.Text))
            {
                MessageBox.Show("Le numéro de téléphone doit être un numéro valide (ex: 7XXXXXXXX ou +2217XXXXXXXX).",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }// Récupérer l'ID de l'étudiant sélectionné
            var etudiantId = (int)dataGridEtudiant.CurrentRow.Cells["Id"].Value;
            // Vérifier l'unicité de l'email (sauf pour l'étudiant en cours de modification)
            if (_context.Etudiants.Any(etudiant => etudiant.Email == txtemail.Text && etudiant.Id != etudiantId))
            {
                MessageBox.Show("Un étudiant avec cet email existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Vérifier l'unicité du téléphone (sauf pour l'étudiant en cours de modification)
            if (_context.Etudiants.Any(etudiant => etudiant.Telephone == txttelephone.Text && etudiant.Id != etudiantId))
            {
                MessageBox.Show("Un étudiant avec ce numéro de téléphone existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Demander une confirmation avant de modifier
            var confirmation = MessageBox.Show(
                "Êtes-vous sûr de vouloir modifier ?",
                "Confirmation de modification",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmation == DialogResult.Yes)  // Si l'utilisateur confirme
            {
                try
                {
                    // Trouver l'étudiant à modifier
                    var etudiant = _context.Etudiants.Find(etudiantId);
                    if (etudiant != null)
                    {
                        // Mettre à jour les informations de l'étudiant
                        etudiant.Nom = txtnom.Text;
                        etudiant.Prenom = txtprenom.Text;
                        etudiant.DateNaissance = dtpdatenaissance.Value;
                        etudiant.sexe = cmbsexe.SelectedItem.ToString();
                        etudiant.Adresse = txtadresse.Text;
                        etudiant.Telephone = txttelephone.Text;
                        etudiant.Email = txtemail.Text;
                        etudiant.IdClasse = (int)cmbclasse.SelectedValue;
                        // Sauvegarder les modifications
                        _context.SaveChanges();
                        // Rafraîchir la liste des étudiants
                        Refresh();
                        // Vider les champs après la modification
                        ClearFields();
                        MessageBox.Show("Étudiant modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SupprimerEtudiant_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridEtudiant.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Demander une confirmation avant de supprimer
            var confirmation = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmation == DialogResult.Yes)  // Si l'utilisateur confirme
            {
                try
                {
                    // Récupérer l'ID de l'étudiant sélectionné
                    var etudiantId = (int)dataGridEtudiant.CurrentRow.Cells["Id"].Value;
                    // Trouver l'étudiant à supprimer
                    var etudiant = _context.Etudiants.Find(etudiantId);

                    if (etudiant != null)
                    {
                        // Supprimer l'étudiant
                        _context.Etudiants.Remove(etudiant);
                        _context.SaveChanges();

                        // Afficher un message de succès
                        MessageBox.Show("L'étudiant a été supprimé avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Rafraîchir les données
                        Refresh();

                        // Vider les champs après la suppression
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

