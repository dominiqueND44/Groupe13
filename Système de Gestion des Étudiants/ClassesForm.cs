using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class ClassesForm : Form
    {
        private int selectedClassId = -1; // Stocke l'ID de la classe sélectionnée

        public ClassesForm()
        {
            InitializeComponent();
            this.Load += ClassesForm_Load;
            dataGridClasse.CellClick += DataGridClasse_CellClick;
        }

        // Charger la liste des classes dans le DataGridView
        private void ClassesForm_Load(object sender, EventArgs e)
        {
            Actualiser(); // Actualise l'affichage des classes
        }

        // Actualiser l'affichage des classes dans le DataGridView
        private void Actualiser()
        {
            using (var db = new DBGestionContext())
            {
                var classes = db.Classes.Select(c => new { c.Id, c.NomClasse }).ToList();
                dataGridClasse.DataSource = classes;
            }
        }

        // Gérer la sélection d'une classe dans le DataGridView
        private void DataGridClasse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedClassId = Convert.ToInt32(dataGridClasse.Rows[e.RowIndex].Cells["Id"].Value);
                textBoxNomclasse.Text = dataGridClasse.Rows[e.RowIndex].Cells["NomClasse"].Value.ToString();
            }
        }

        // Ajouter une nouvelle classe
        private void AjoutClasse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomclasse.Text))
            {
                MessageBox.Show("Veuillez entrer un nom de classe !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                var classe = new Classe { NomClasse = textBoxNomclasse.Text };
                db.Classes.Add(classe);
                db.SaveChanges();
                MessageBox.Show("Classe ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualiser(); // Actualise la liste des classes
            }
        }

        // Modifier une classe existante
        private void ModifierClasse_Click(object sender, EventArgs e)
        {
            if (selectedClassId == -1)
            {
                MessageBox.Show("Veuillez sélectionner une classe à modifier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                var classe = db.Classes.Find(selectedClassId);
                if (classe != null)
                {
                    classe.NomClasse = textBoxNomclasse.Text;
                    db.SaveChanges();
                    MessageBox.Show("Classe modifiée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiser(); // Actualise la liste des classes
                }
            }
        }

        // Supprimer une classe existante
        private void SupprimerClasse_Click(object sender, EventArgs e)
        {
            if (selectedClassId == -1)
            {
                MessageBox.Show("Veuillez sélectionner une classe à supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                var classe = db.Classes.Find(selectedClassId);
                if (classe != null)
                {
                    db.Classes.Remove(classe);
                    db.SaveChanges();
                    MessageBox.Show("Classe supprimée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiser(); // Actualise la liste des classes
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AssociationClasse_Click(object sender, EventArgs e)
        {
            AssociationCoursMatieresProfesseuràClasseForm associationCoursMatieresProfesseuràClasseForm = new AssociationCoursMatieresProfesseuràClasseForm();
            associationCoursMatieresProfesseuràClasseForm.Show();
        }
    }
}
