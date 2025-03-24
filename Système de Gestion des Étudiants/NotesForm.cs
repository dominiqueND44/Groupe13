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
            comboBoxEtudiant.SelectedIndexChanged += comboBoxEtudiant_SelectedIndexChanged;
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            ChargerEtudiants();
            ChargerMatieres();
            Actualiser();
        }

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

        private void Actualiser()
        {
            using (var db = new DBGestionContext())
            {
                var notes = from n in db.Notes
                            join e in db.Etudiants on n.Etudiant_Id equals e.Id
                            join m in db.Matieres on n.Matiere_Id equals m.Id
                            select new
                            {
                                Id = n.Id, // Colonne "Id"
                                Etudiant = e.Nom + " " + e.Prenom, // Colonne "Etudiant"
                                Matiere = m.NomMatiere, // Colonne "Matiere"
                                Note = n.Notes // Colonne "Note"
                            };

                dataGridNote.DataSource = notes.ToList();
            }
        }

        private void DataGridNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Vérifie que l'utilisateur a cliqué sur une ligne valide
            {
                // Récupérer la ligne sélectionnée
                var row = dataGridNote.Rows[e.RowIndex];

                // Récupérer l'ID de la note sélectionnée
                int noteId = Convert.ToInt32(row.Cells["Id"].Value);

                using (var db = new DBGestionContext())
                {
                    // Récupérer la note correspondante dans la base de données
                    var note = db.Notes.Find(noteId);
                    if (note == null)
                    {
                        MessageBox.Show("Note non trouvée !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Mettre à jour selectedEtuId avec l'ID de l'étudiant associé à la note
                    selectedEtuId = note.Etudiant_Id;

                    // Mettre à jour le ComboBox de l'étudiant
                    comboBoxEtudiant.SelectedValue = selectedEtuId;

                    // Charger les matières associées à l'étudiant sélectionné
                    ChargerMatieresParEtudiant(selectedEtuId);

                    // Définir la matière sélectionnée dans le ComboBox
                    string matiereSelectionnee = row.Cells["Matiere"].Value.ToString();
                    comboBoxMatiere.SelectedValue = comboBoxMatiere.Items.Cast<dynamic>()
                        .FirstOrDefault(x => x.NomMatiere == matiereSelectionnee)?.Id;

                    // Définir la note dans le TextBox
                    textBoxNote.Text = row.Cells["Note"].Value.ToString();
                }
            }
        }

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

                var existingNote = db.Notes.FirstOrDefault(n => n.Etudiant_Id == etudiantId && n.Matiere_Id == matiereId);

                if (existingNote != null)
                {
                    MessageBox.Show("Une note existe déjà pour cet étudiant et cette matière !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var note = new Note
                {
                    Etudiant_Id = etudiantId,
                    Matiere_Id = matiereId,
                    Notes = float.Parse(textBoxNote.Text)
                };

                db.Notes.Add(note);
                db.SaveChanges();
                MessageBox.Show("Note ajoutée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualiser();
            }
        }

        private void ModifierNote_Click(object sender, EventArgs e)
        {
            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner une note à modifier !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                int etudiantId = Convert.ToInt32(comboBoxEtudiant.SelectedValue);
                int matiereId = Convert.ToInt32(comboBoxMatiere.SelectedValue);

                // Vérifier si une note existe déjà pour cet étudiant et cette matière
                var existingNote = db.Notes.FirstOrDefault(n => n.Etudiant_Id == etudiantId && n.Matiere_Id == matiereId && n.Id != selectedEtuId);

                if (existingNote != null)
                {
                    MessageBox.Show("Une note existe déjà pour cet étudiant et cette matière !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var note = db.Notes.Find(selectedEtuId);
                if (note != null)
                {
                    note.Etudiant_Id = etudiantId;
                    note.Matiere_Id = matiereId;
                    note.Notes = float.Parse(textBoxNote.Text);
                    db.SaveChanges();
                    MessageBox.Show("Note modifiée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Actualiser();
                }
            }
        }

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

        private void CalculerMoyenne_Click(object sender, EventArgs e)
        {
            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                // Récupérer l'étudiant sélectionné
                var etudiant = db.Etudiants.Find(selectedEtuId);
                if (etudiant == null)
                {
                    MessageBox.Show("Étudiant non trouvé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Récupérer les matières de la classe de l'étudiant
                var matieres = from cmpc in db.CoursMatieresProfesseursClasses
                               join m in db.Matieres on cmpc.IdMatiere equals m.Id
                               where cmpc.IdClasse == etudiant.IdClasse
                               select m;

                // Récupérer les notes de l'étudiant
                var notes = db.Notes.Where(n => n.Etudiant_Id == selectedEtuId).ToList();

                double sommeNotes = 0;
                int nombreMatieres = 0;

                // Calculer la somme des notes et le nombre de matières
                foreach (var matiere in matieres)
                {
                    var note = notes.FirstOrDefault(n => n.Matiere_Id == matiere.Id);
                    sommeNotes += note?.Notes ?? 0; // Si la note n'existe pas, utiliser 0
                    nombreMatieres++;
                }

                if (nombreMatieres == 0)
                {
                    MessageBox.Show("Aucune matière trouvée pour cet étudiant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculer et afficher la moyenne
                double moyenne = sommeNotes / nombreMatieres;
                MessageBox.Show($"La moyenne est : {moyenne:F2}", "Moyenne", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AfficheReleveNotes_Click(object sender, EventArgs e)
        {
            if (selectedEtuId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un étudiant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new DBGestionContext())
            {
                // Récupérer l'étudiant sélectionné
                var etudiant = db.Etudiants.Find(selectedEtuId);
                if (etudiant == null)
                {
                    MessageBox.Show("Étudiant non trouvé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Récupérer les matières de la classe de l'étudiant
                var matieres = from cmpc in db.CoursMatieresProfesseursClasses
                               join m in db.Matieres on cmpc.IdMatiere equals m.Id
                               where cmpc.IdClasse == etudiant.IdClasse
                               select m;

                // Récupérer les notes de l'étudiant
                var notes = db.Notes.Where(n => n.Etudiant_Id == selectedEtuId).ToList();

                var message = "Relevé de Notes:\n\n";
                double sommeNotes = 0;
                int nombreMatieres = 0;

                // Construire le message avec les notes et calculer la somme des notes
                foreach (var matiere in matieres)
                {
                    var note = notes.FirstOrDefault(n => n.Matiere_Id == matiere.Id);
                    message += $"{matiere.NomMatiere}: {(note != null ? note.Notes.ToString() : "Non noté")}\n";
                    sommeNotes += note?.Notes ?? 0; // Si la note n'existe pas, utiliser 0
                    nombreMatieres++;
                }

                if (nombreMatieres == 0)
                {
                    MessageBox.Show("Aucune matière trouvée pour cet étudiant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calculer et afficher la moyenne
                double moyenne = sommeNotes / nombreMatieres;
                message += $"\nMoyenne : {moyenne:F2}";

                MessageBox.Show(message, "Relevé de Notes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxEtudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEtudiant.SelectedItem != null)
            {
                // Mettre à jour selectedEtuId avec l'ID de l'étudiant sélectionné
                var selectedEtudiant = comboBoxEtudiant.SelectedItem as dynamic;
                selectedEtuId = selectedEtudiant.Id;

                // Charger les matières associées à l'étudiant sélectionné
                ChargerMatieresParEtudiant(selectedEtuId);
            }
        }

        private void ChargerMatieresParEtudiant(int etudiantId)
        {
            using (var db = new DBGestionContext())
            {
                var etudiant = db.Etudiants.Find(etudiantId);
                if (etudiant == null)
                {
                    MessageBox.Show("Étudiant non trouvé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var matieres = from cmpc in db.CoursMatieresProfesseursClasses
                               join m in db.Matieres on cmpc.IdMatiere equals m.Id
                               where cmpc.IdClasse == etudiant.IdClasse
                               select m;

                comboBoxMatiere.DataSource = matieres.ToList();
                comboBoxMatiere.DisplayMember = "NomMatiere";
                comboBoxMatiere.ValueMember = "Id";
            }
        }

        private void ViderChamps_Click(object sender, EventArgs e)
        {
            comboBoxEtudiant.SelectedIndex = -1;
            comboBoxMatiere.SelectedIndex = -1;
            textBoxNote.Clear();

            // Recharger les matières disponibles
            ChargerMatieres();
        }
    }
}