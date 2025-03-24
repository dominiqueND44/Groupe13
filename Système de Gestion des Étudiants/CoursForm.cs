using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class CoursForm: Form
    {
        private int selectedCoursId;
        public CoursForm()
        {
            InitializeComponent();
            actualize(); // Mettre à jour les matieres
            dataGridCours.CellClick += DataGridCours_CellClick; // Attacher l'événement CellClick pour la sélection dans le DataGridView

        }
        public void actualize()
        {
            using (var db = new DBGestionContext())
            {
                dataGridCours.DataSource = db.Cours
                    .Select(c => new
                    {
                        ID = c.Id,
                        NomCours = c.NomCours,
                        Description = c.Description
                    })
                    .ToList();

                // Rendre la colonne ID visible
                dataGridCours.Columns["ID"].Visible = true;
            }
        }

        private void DataGridCours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCoursId = Convert.ToInt32(dataGridCours.Rows[e.RowIndex].Cells["ID"].Value);
                textBoxNomCours.Text = dataGridCours.Rows[e.RowIndex].Cells["NomCours"].Value.ToString();
                textBoxDescriptionCours.Text = dataGridCours.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                AjoutCours.Enabled = false;
               
            }
        }

        private void AjoutCours_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomCours.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescriptionCours.Text))
            {
                MessageBox.Show("les champs sont obligatoires !");
                return;
            }

            using (var db = new DBGestionContext())
            {
                if (db.Cours.Any(m => m.NomCours == textBoxNomCours.Text))
                {
                    MessageBox.Show("Ce Cours existe déja !");
                    return;
                }

                var cours = new Cours
                {
                NomCours = textBoxNomCours.Text,
                Description = textBoxDescriptionCours.Text

                };

                db.Cours.Add(cours);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Cours ajouté avec succès !");
                    actualize(); // Mettre à jour les cours
                    textBoxNomCours.Text = "";
                    textBoxDescriptionCours.Text = "";
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout du Cours.");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Modifier un cours

            if (selectedCoursId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un cours avant de modifier !");
                return;
            }

            using (var db = new DBGestionContext())
            {
                var cours = db.Cours.Find(selectedCoursId);
                if (cours == null)
                {
                    MessageBox.Show("Cours introuvable !");
                    return;
                }
                cours.NomCours = textBoxNomCours.Text;
                cours.Description = textBoxDescriptionCours.Text;
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Cours modifié avec succès !");
                    actualize(); // Mettre à jour les cours
                    textBoxNomCours.Text = "";
                    textBoxDescriptionCours.Text = "";
                    AjoutCours.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification du cours.");
                }
            }




        }

        private void SupprimerCours_Click(object sender, EventArgs e)
        {
            if (selectedCoursId == 0)
            {
                MessageBox.Show("Veuillez sélectionner un cours avant de supprimer !");
                return;
            }
            using (var db = new DBGestionContext())
            {
                var cours = db.Cours.Find(selectedCoursId);
                if (cours == null)
                {
                    MessageBox.Show("Cours introuvable !");
                    return;
                }
                db.Cours.Remove(cours);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Cours supprimé avec succès !");
                    actualize(); // Mettre à jour les cours
                    textBoxNomCours.Text = "";
                    textBoxDescriptionCours.Text = "";
                    AjoutCours.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression du cours.");
                }
            }


        }

        private void AjoutMatiere_Click(object sender, EventArgs e)
        {
            AjoutMatieresCoursForm ajoutMatieresCoursForm = new AjoutMatieresCoursForm();
            ajoutMatieresCoursForm.Show();  

        }

        private void ViderChamps_Click(object sender, EventArgs e)
        {
            textBoxNomCours.Text = "";
            textBoxDescriptionCours.Text = "";
            AjoutCours.Enabled = true;


        }

        private void FermerFenetre_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
