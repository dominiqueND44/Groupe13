using System;
using System.Linq;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class NotesForm : Form
    {
        private int selectedEtuId = -1; // Stocke l'ID sélectionné

        public NotesForm()
        {
            InitializeComponent();
            this.Load += NotesForm_Load;
            dataGridNote.CellClick += DataGridNote_CellClick;
            comboBoxEtudiant.SelectedIndexChanged += comboBoxEtudiant_SelectedIndexChanged; // Ajouté
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            ChargerEtudiants(); // Remplir le comboBox des étudiants
            ChargerMatieres();  // Remplir le comboBox des matières
            Actualiser();       // Charger les notes
        }

        // Méthode pour charger les étudiants dans le comboBox
        private void ChargerEtudiants()
        {
            using (var db = new DBGestionContext())
            {
                var etudiants = db.Etudiants.Select(e => new { e.Id, e.Nom, e.Prenom }).ToList();
                comboBoxEtudiant.DataSource = etudiants;
                comboBoxEtudiant.DisplayMember = "Nom";
                comboBoxEtudiant.ValueMember = "Id";
            }
        }

        // Méthode pour charger les matières dans le comboBox
        private void ChargerMatieres()
        {
            using (var db = new DBGestionContext())
            {
                var matieres = db.Matieres.Select(m => new { m.Id, m.NomMatiere }).ToList();
                comboBoxMatiere.DataSource = matieres;
                comboBoxMatiere.DisplayMember = "NomMatiere";
                comboBoxMatiere.ValueMember = "Id";
            }
        }

        // Méthode pour actualiser la grille des notes
        private void Actualiser()
        {
            using (var db = new DBGestionContext())
            {
                var notes = from n in db.Notes
                            join e in db.Etudiants on n.Etudiant_Id equals e.Id
                            join m in db.Matieres on n.Matiere_Id equals m.Id
                            select new
                            {
                                n.Id,
                                Etudiant = e.Nom + " " + e.Prenom,
                                Matiere = m.NomMatiere,
                                n.Notes
                            };

                dataGridNote.DataSource = notes.ToList();
            }
        }

        // Méthode pour la sélection d'une note dans la grille
        private void DataGridNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedEtuId = Convert.ToInt32(dataGridNote.Rows[e.RowIndex].Cells["ID"].Value);
                comboBoxEtudiant.SelectedValue = dataGridNote.Rows[e.RowIndex].Cells["Etudiant"].Value.ToString();
                comboBoxMatiere.SelectedValue = dataGridNote.Rows[e.RowIndex].Cells["Matiere"].Value.ToString();
                textBoxNote.Text = dataGridNote.Rows[e.RowIndex].Cells["Notes"].Value.ToString();
            }
        }

        // Méthode pour ajouter une note
        // Méthode pour ajouter une note
        private void AjoutNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNote.Text) || comboBoxMatiere.SelectedValue == null || comboBoxEtudiant.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                int etudiantId = Convert.ToInt32(comboBoxEtudiant.SelectedValue);
                int matiereId = Convert.ToInt32(comboBoxMatiere.SelectedValue);

                // Vérifier si une note existe déjà pour cet étudiant et cette matière
                var existingNote = db.Notes
                    .FirstOrDefault(n => n.Etudiant_Id == etudiantId && n.Matiere_Id == matiereId);

                if (existingNote != null)
                {
                    MessageBox.Show("Une note existe déjà pour cet étudiant et cette matière !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ajouter la nouvelle note si elle n'existe pas déjà
                var note = new Note
                {
                    Etudiant_Id = etudiantId,
                    Matiere_Id = matiereId,
                    Notes = textBoxNote.Text
                };

                db.Notes.Add(note);
                db.SaveChanges();
                MessageBox.Show("Note ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualiser();
            }
        }

        // Méthode pour modifier une note
        private void ModifierNote_Click(object sender, EventArgs e)
        {
            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner une note à modifier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNote.Text) || comboBoxMatiere.SelectedValue == null || comboBoxEtudiant.SelectedValue == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                var note = db.Notes.Find(selectedEtuId);
                if (note != null)
                {
                    note.Etudiant_Id = Convert.ToInt32(comboBoxEtudiant.SelectedValue);
                    note.Matiere_Id = Convert.ToInt32(comboBoxMatiere.SelectedValue);
                    note.Notes = textBoxNote.Text;
                    db.SaveChanges();
                    MessageBox.Show("Note modifiée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiser();
                }
            }
        }

        // Méthode pour supprimer une note
        private void SupprimerClasse_Click(object sender, EventArgs e)
        {
            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner une note à supprimer !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                var note = db.Notes.Find(selectedEtuId);
                if (note != null)
                {
                    db.Notes.Remove(note);
                    db.SaveChanges();
                    MessageBox.Show("Note supprimée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiser();
                }
            }
        }

        // Méthode pour calculer la moyenne des notes
        // Méthode pour calculer la moyenne des notes
        private void CalculerMoyenne_Click(object sender, EventArgs e)
        {
            // Désactiver les boutons Ajouter, Modifier, Supprimer
            ToggleActionButtons(false);

            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant avant de calculer la moyenne !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ToggleActionButtons(true); // Réactiver les boutons après l'erreur
                return;
            }

            using (var db = new DBGestionContext())
            {
                // Vérifier s'il existe des notes pour l'étudiant
                var notes = db.Notes.Where(n => n.Etudiant_Id == selectedEtuId).ToList();

                if (notes.Count == 0)
                {
                    MessageBox.Show("Aucune note disponible pour cet étudiant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ToggleActionButtons(true); // Réactiver les boutons après l'erreur
                    return;
                }

                // Calculer la moyenne des notes
                var moyenne = notes.Average(n => Convert.ToDouble(n.Notes));
                MessageBox.Show($"La moyenne des notes de l'étudiant est : {moyenne}", "Calcul de la moyenne", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ToggleActionButtons(true); // Réactiver les boutons après le calcul
            }
        }


        // Méthode pour afficher le relevé de notes
        private void AfficheReleveNotes_Click(object sender, EventArgs e)
        {
            // Désactiver les boutons Ajouter, Modifier, Supprimer
            ToggleActionButtons(false);

            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant avant d'afficher le relevé de notes !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ToggleActionButtons(true); // Réactiver les boutons après l'erreur
                return;
            }

            using (var db = new DBGestionContext())
            {
                var notes = from n in db.Notes
                            join m in db.Matieres on n.Matiere_Id equals m.Id
                            where n.Etudiant_Id == selectedEtuId
                            select new { Matiere = m.NomMatiere, n.Notes };

                var message = "Relevé de Notes:\n\n";
                foreach (var note in notes)
                {
                    message += $"{note.Matiere}: {note.Notes}\n";
                }

                MessageBox.Show(message, "Relevé de Notes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ToggleActionButtons(true); // Réactiver les boutons après l'affichage
        }

        // Méthode pour activer/désactiver les boutons d'action
        private void ToggleActionButtons(bool enabled)
        {
            AjoutNote.Enabled = enabled;
            ModifierNote.Enabled = enabled;
            SupprimerNote.Enabled = enabled;
        }

        // Gérer les changements de texte dans le champ note
        private void textBoxNote_TextChanged(object sender, EventArgs e)
        {
            // Implémentation à ajouter ici si nécessaire
        }

        // Gérer les changements de sélection de l'étudiant
        private void comboBoxEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEtudiant.SelectedItem != null)
            {
                // Accéder à l'objet anonyme sélectionné
                var selectedEtudiant = comboBoxEtudiant.SelectedItem as dynamic;

                // Extraire l'ID de l'étudiant
                int etudiantId = selectedEtudiant.Id;

                // Charger les matières par étudiant
                ChargerMatieresParEtudiant(etudiantId);
            }
        }


        // Méthode pour charger les matières en fonction de l'étudiant sélectionné
        private void ChargerMatieresParEtudiant(int etudiantId)
        {
            using (var db = new DBGestionContext())
            {
                var matieres = db.Matieres
                    .Join(db.Notes, m => m.Id, n => n.Matiere_Id, (m, n) => new { m.Id, m.NomMatiere })
                    .Where(x => x.Id == etudiantId)
                    .ToList();

                comboBoxMatiere.DataSource = matieres;
                comboBoxMatiere.DisplayMember = "NomMatiere";
                comboBoxMatiere.ValueMember = "Id";
            }
        }



        // Gérer les changements de sélection de la matière
        private void comboBoxMatNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
