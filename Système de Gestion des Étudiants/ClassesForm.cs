using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class ClassesForm: Form
    {
        private DBGestionContext _context;
        public ClassesForm()
        {
            InitializeComponent();
            _context = new DBGestionContext();

            // Empêcher la modification directe dans le DataGridView
            dataGridClasse.ReadOnly = true;
            // Empêcher l'ajout et la suppression de lignes
            dataGridClasse.AllowUserToAddRows = false;
            dataGridClasse.AllowUserToDeleteRows = false;
            Refresh();
        }
        private void Refresh()
        {
            LoadClasse();  // Rafraîchir la liste des classes
            txtNomClasse.Clear();  // Vider le champ de texte
                                   // Désélectionner toutes les lignes du DataGridView
            dataGridClasse.ClearSelection();
            AjoutClasse.Enabled = true;
        }

        private void LoadClasse()
        {
            var classes = _context.Classes.ToList();
            dataGridClasse.DataSource = classes; // Met à jour la source de données du DataGridView
            // Masquer toutes les colonnes sauf "Id" et "NomClasse"
            foreach (DataGridViewColumn col in dataGridClasse.Columns)
            {
                if (col.Name != "Id" && col.Name != "NomClasse")
                {
                    col.Visible = false;
                }
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClassesForm_Load(object sender, EventArgs e)
        {
            
        }
        
        private void textBoxNomclasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void AjoutClasse_Click(object sender, EventArgs e)
        {
            // Validation du champ txtNomClasse
            if (string.IsNullOrWhiteSpace(txtNomClasse.Text))
            {
                MessageBox.Show("Veuillez saisir un nom de classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Vérifier que le nom de la classe ne contient pas de caractères spéciaux et ne commence pas par un chiffre
            if (!ValiderNomClasse(txtNomClasse.Text))
            {
                return; // Si la validation échoue, on arrête le processus
            }
            // Vérifier que le nom de la classe est unique
            if (!VerifierNomClasseUnique(txtNomClasse.Text))
            {
                return; // Si le nom n'est pas unique, on arrête le processus

            }

            try
            {
                // Ajouter une nouvelle classe à la base de données
                var classe = new Classe
                {
                    NomClasse = txtNomClasse.Text
                };
                _context.Classes.Add(classe);
                _context.SaveChanges();
                MessageBox.Show("Classe ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh(); // Rafraîchir la liste des classes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite lors de l'ajout de la classe. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerifierNomClasseUnique(string text)
        {
            // Vérifier si le nom de la classe existe déjà dans la base de données
            var classe = _context.Classes.FirstOrDefault(c => c.NomClasse == text);
            if (classe != null)
            {
                MessageBox.Show("Le nom de la classe existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ValiderNomClasse(string text)
        {
            
            // Supprimer les espaces avant et après
            text = text.Trim();
            // Vérifier qu'il ne contient pas de caractères spéciaux
            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"[^a-zA-Z0-9\s]"))
            {
                MessageBox.Show("Le nom de la classe ne doit pas contenir de caractères spéciaux.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ModifierClasse_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridClasse.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une classe à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validation du champ txtNomClasse
            if (string.IsNullOrWhiteSpace(txtNomClasse.Text))
            {
                MessageBox.Show("Veuillez entrer un nom de classe.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Vérifier que le nom de la classe ne contient pas de caractères spéciaux et ne commence pas par un chiffre
            if (!ValiderNomClasse(txtNomClasse.Text))
            {
                return;
            }
            // Vérifier que le nom de la classe est unique
            if (!VerifierNomClasseUnique(txtNomClasse.Text))
            {
                return; // Si le nom n'est pas unique, on arrête le processus

            }
            // Demander une confirmation avant de modifier
            var confirmation = MessageBox.Show(
                "Êtes-vous sûr de vouloir modifier ?",
                "Confirmation de modification",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    // Récupérer l'ID de la classe sélectionnée
                    var classeId = (int)dataGridClasse.CurrentRow.Cells["Id"].Value;
                    // Récupérer la classe à modifier
                    var classe = _context.Classes.Find(classeId);
                    if (classe != null)
                    {
                        // Mettre à jour le nom de la classe
                        classe.NomClasse = txtNomClasse.Text;
                        // Sauvegarder les modifications
                        _context.SaveChanges();
                        MessageBox.Show("Classe modifiée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh(); // Rafraîchir la liste des classes
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la modification de la classe. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupprimerClasse_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridClasse.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Demander une confirmation avant de supprimer
            var confirmation = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer cette classe et tous ses étudiants ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    // Récupérer l'ID de la classe sélectionnée
                    var classeId = (int)dataGridClasse.CurrentRow.Cells["Id"].Value;
                    // Récupérer la classe à supprimer
                    var classe = _context.Classes.Find(classeId);
                    if (classe != null)
                    {
                        // Supprimer la classe de la base de données
                        _context.Classes.Remove(classe);
                        _context.SaveChanges();
                        MessageBox.Show("Classe supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh(); // Rafraîchir la liste des classes
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite lors de la suppression de la classe. Veuillez réessayer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AssociationClasse_Click(object sender, EventArgs e)
        {
            if (dataGridClasse.SelectedRows.Count > 0)
            {
                int selectedClassId = (int)dataGridClasse.SelectedRows[0].Cells["Id"].Value;

                // Créer une instance du formulaire d'association et passer l'ID de la classe
                AssociationCoursMatieresProfesseuràClasseForm formAssocier = new AssociationCoursMatieresProfesseuràClasseForm(selectedClassId);

                // Afficher le formulaire d'association
                formAssocier.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une classe.");
            }
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

