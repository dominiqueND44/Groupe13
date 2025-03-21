using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class EtudiantsForm : Form
    {
        private int selectedEtuId = -1; // Stocke l'ID sélectionné

        public EtudiantsForm()
        {
            InitializeComponent();
            this.Load += EtudiantsForm_Load;
            dataGridEtudiant.CellClick += DataGridEtudiant_CellClick;
        }

        private void EtudiantsForm_Load(object sender, EventArgs e)
        {
            if (comboBoxSexeetu.Items.Count == 0) // 🔹 Vérifier si la liste est déjà remplie
            {
                comboBoxSexeetu.Items.AddRange(new string[] { "M", "F" });
            }
            ChargerClasses(); // Remplir le comboBox des classes
            Actualiser(); // Charger les étudiants
        }

        private void ChargerClasses()
        {
            using (var db = new DBGestionContext())
            {
                var classes = db.Classes.Select(c => new { c.Id, c.NomClasse }).ToList();
                comboBoxClasseetu.DataSource = classes;
                comboBoxClasseetu.DisplayMember = "NomClasse";
                comboBoxClasseetu.ValueMember = "Id";
            }
        }

        private void Actualiser()
        {
            using (var db = new DBGestionContext())
            {
                var etudiants = from e in db.Etudiants
                                join c in db.Classes on e.IdClasse equals c.Id
                                select new
                                {
                                    e.Id,
                                    e.Nom,
                                    e.Prenom,
                                    e.Matricule,
                                    e.DateNaissance,
                                    e.Email,
                                    e.Adresse,
                                    e.Telephone,
                                    e.Sexe,
                                    Classe = c.NomClasse // 🔹 Récupérer le nom de la classe
                                };

                dataGridEtudiant.DataSource = etudiants.ToList();
            }
        }


        private void DataGridEtudiant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedEtuId = Convert.ToInt32(dataGridEtudiant.Rows[e.RowIndex].Cells["ID"].Value);
                textBoxNometu.Text = dataGridEtudiant.Rows[e.RowIndex].Cells["Nom"].Value.ToString();
                textBoxPrenometu.Text = dataGridEtudiant.Rows[e.RowIndex].Cells["Prenom"].Value.ToString();
                textBoxMatriculeetu.Text = dataGridEtudiant.Rows[e.RowIndex].Cells["Matricule"].Value.ToString();
                dateTimePickeretu.Value = Convert.ToDateTime(dataGridEtudiant.Rows[e.RowIndex].Cells["DateNaissance"].Value);
                textBoxEmailetu.Text = dataGridEtudiant.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                textBoxAdresseetu.Text = dataGridEtudiant.Rows[e.RowIndex].Cells["Adresse"].Value.ToString();
                textBoxTeletu.Text = dataGridEtudiant.Rows[e.RowIndex].Cells["Telephone"].Value.ToString();
                comboBoxSexeetu.SelectedItem = dataGridEtudiant.Rows[e.RowIndex].Cells["Sexe"].Value.ToString();
                comboBoxClasseetu.Text = dataGridEtudiant.Rows[e.RowIndex].Cells["Classe"].Value.ToString();
            }
        }

        private void AjoutEtudiant_Click(object sender, EventArgs e)
        {
            // Vérification de tous les champs
            if (string.IsNullOrWhiteSpace(textBoxNometu.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrenometu.Text) ||
                string.IsNullOrWhiteSpace(textBoxMatriculeetu.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmailetu.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdresseetu.Text) ||
                string.IsNullOrWhiteSpace(textBoxTeletu.Text) ||
                comboBoxSexeetu.SelectedItem == null || // Vérifier si une option est sélectionnée dans le ComboBox Sexe
                comboBoxClasseetu.SelectedValue == null) // Vérifier si une classe est sélectionnée
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                var etudiant = new Etudiant
                {
                    Nom = textBoxNometu.Text,
                    Prenom = textBoxPrenometu.Text,
                    Matricule = textBoxMatriculeetu.Text,
                    DateNaissance = dateTimePickeretu.Value,
                    Email = textBoxEmailetu.Text,
                    Adresse = textBoxAdresseetu.Text,
                    Telephone = textBoxTeletu.Text,
                    Sexe = comboBoxSexeetu.SelectedItem.ToString(),
                    IdClasse = Convert.ToInt32(comboBoxClasseetu.SelectedValue)
                };

                db.Etudiants.Add(etudiant);
                db.SaveChanges();
                MessageBox.Show("Étudiant ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualiser();
            }
        }


        private void ModifierEtudiant_Click(object sender, EventArgs e)
        {
            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à modifier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Vérification de tous les champs
            if (string.IsNullOrWhiteSpace(textBoxNometu.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrenometu.Text) ||
                string.IsNullOrWhiteSpace(textBoxMatriculeetu.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmailetu.Text) ||
                string.IsNullOrWhiteSpace(textBoxAdresseetu.Text) ||
                string.IsNullOrWhiteSpace(textBoxTeletu.Text) ||
                comboBoxSexeetu.SelectedItem == null || // Vérifier si une option est sélectionnée dans le ComboBox Sexe
                comboBoxClasseetu.SelectedValue == null) // Vérifier si une classe est sélectionnée
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                var etudiant = db.Etudiants.Find(selectedEtuId);
                if (etudiant != null)
                {
                    etudiant.Nom = textBoxNometu.Text;
                    etudiant.Prenom = textBoxPrenometu.Text;
                    etudiant.Matricule = textBoxMatriculeetu.Text;
                    etudiant.DateNaissance = dateTimePickeretu.Value;
                    etudiant.Email = textBoxEmailetu.Text;
                    etudiant.Adresse = textBoxAdresseetu.Text;
                    etudiant.Telephone = textBoxTeletu.Text;
                    etudiant.Sexe = comboBoxSexeetu.SelectedItem.ToString();
                    etudiant.IdClasse = Convert.ToInt32(comboBoxClasseetu.SelectedValue);
                    db.SaveChanges();
                    MessageBox.Show("Étudiant modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiser();
                }
            }
        }


        private void SupprimerEtudiant_Click(object sender, EventArgs e)
        {
            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant à supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBGestionContext())
            {
                var etudiant = db.Etudiants.Find(selectedEtuId);
                if (etudiant != null)
                {
                    db.Etudiants.Remove(etudiant);
                    db.SaveChanges();
                    MessageBox.Show("Étudiant supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiser();
                }
            }
        }

        private void textBoxRechercheetu_TextChanged(object sender, EventArgs e)
        {
            using (var db = new DBGestionContext())
            {
                var result = db.Etudiants.Where(c => c.Nom.Contains(textBoxRechercheetu.Text) || c.Prenom.Contains(textBoxRechercheetu.Text))
                    .Select(c => new
                    {
                        c.Id,
                        c.Nom,
                        c.Prenom,
                        c.Matricule,
                        c.DateNaissance,
                        c.Email,
                        c.Adresse,
                        c.Telephone,
                        c.Sexe,
                        Classe = c.Classe.NomClasse
                    })
                    .ToList();
                dataGridEtudiant.DataSource = result;

            }
        }
       
    }
}