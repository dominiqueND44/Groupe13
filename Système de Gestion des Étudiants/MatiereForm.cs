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
    public partial class MatiereForm: Form
    {
        private int selectedMatiereId;
        public MatiereForm()
        {
            InitializeComponent();
            actualize(); // Mettre à jour les matieres
            dataGridMat.CellClick += DataGridMat_CellClick; // Attacher l'événement CellClick pour la sélection dans le DataGridView
           /* if (textBoxNomMatiere != null)
            {
                ModifierMatiere.Enabled = false;
                SupprimerMatiere.Enabled = false;
            }
            else
            {
                ModifierMatiere.Enabled = true;
                SupprimerMatiere.Enabled = true;
            }
           */
        }
        public void actualize()
        {
            using (var db = new DBGestionContext())
            {
                dataGridMat.DataSource = db.Matieres
                    .Select(m => new
                    {
                        ID = m.Id,
                        NomMatiere = m.NomMatiere,
                       
                    })
                    .ToList();

                // Rendre la colonne ID visible
                dataGridMat.Columns["ID"].Visible = true;
            }
        }
        private void DataGridMat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedMatiereId = Convert.ToInt32(dataGridMat.Rows[e.RowIndex].Cells["ID"].Value);
                textBoxNomMatiere.Text = dataGridMat.Rows[e.RowIndex].Cells["NomMatiere"].Value.ToString();
                AjoutMatiere.Enabled = false;
                //ModifierMatiere.Enabled = true;
               // SupprimerMatiere.Enabled = true;


            }
        }
        private void AjoutMatiere_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNomMatiere.Text))
            {
                MessageBox.Show("le champ est obligatoire !");
                return;
            }
           

            using (var db = new DBGestionContext())
            {
                if (db.Matieres.Any(m => m.NomMatiere == textBoxNomMatiere.Text))
                {
                    MessageBox.Show("Cette matiere existe deja !");
                    return;
                }

                var matiere = new Matiere
                {
                  
                    NomMatiere = textBoxNomMatiere.Text,
                   
                };

                db.Matieres.Add(matiere);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Matiere ajouté avec succès !");
                    actualize(); // Mettre à jour les matieres
                    textBoxNomMatiere.Text = "";    
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout de la matiere.");
                }
            }
        }

        private void ModifierMatiere_Click(object sender, EventArgs e)
        {

            if (selectedMatiereId == 0)
            {
                MessageBox.Show("Veuillez sélectionner une matiere avant de modifier !");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNomMatiere.Text))
            {
                MessageBox.Show("le champ est obligatoire !");
                return;
            }

            using (var db = new DBGestionContext())
            {
                var matiere = db.Matieres.Find(selectedMatiereId);
                if (matiere == null)
                {
                    MessageBox.Show("Matiere introuvable !");
                    return;
                }
              
                matiere.NomMatiere = textBoxNomMatiere.Text;
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Matiere modifié avec succès !");
                    actualize(); // Mettre à jour les matieres
                    textBoxNomMatiere.Text = "";
                    selectedMatiereId = 0;
                }
                else
                {
                    MessageBox.Show("Erreur lors de la modification de la matiere.");
                }

            }

        }

        private void SupprimerMatiere_Click(object sender, EventArgs e)
        {

            if (selectedMatiereId == 0)
            {
                MessageBox.Show("Veuillez sélectionner une matiere avant de supprimer !");
                return;
            }
            using (var db = new DBGestionContext())
            {
                var matiere = db.Matieres.Find(selectedMatiereId);
                if (matiere == null)
                {
                    MessageBox.Show("Matiere introuvable !");
                    return;
                }
                db.Matieres.Remove(matiere);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("Matiere supprimé avec succès !");
                    actualize(); // Mettre à jour les matieres
                    textBoxNomMatiere.Text = "";
                    selectedMatiereId = 0;
                }
                else
                {
                    MessageBox.Show("Erreur lors de la suppression de la matiere.");
                }
            }
        }

        private void ViderChamp_Click(object sender, EventArgs e)
        {
            textBoxNomMatiere.Text = "";
            AjoutMatiere.Enabled = true;    
        }

        private void FermerFenetre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
