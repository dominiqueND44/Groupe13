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
    public partial class AssociationCoursMatieresProfesseuràClasseForm: Form
    {
        private DBGestionContext _context;

        private int IdClasse;
        public AssociationCoursMatieresProfesseuràClasseForm(int selectedClassID)
        {
            InitializeComponent();
            _context = new DBGestionContext();
            IdClasse = selectedClassID;
        }
 
        
        private void AssociationCoursMatieresProfesseuràClasseForm_Load(object sender, EventArgs e)
        {
            // Charger les données
            var cours = _context.Cours.ToList();
            var matieres = _context.Matieres.ToList();
            var professeurs = _context.Professeurs.ToList();

            // Remplir les combobox
            cmbCours.DataSource = cours;
            cmbCours.DisplayMember = "NomCours";
            cmbCours.ValueMember = "Id";

            cmbMatiere.DataSource = cours;
            cmbMatiere.DisplayMember = "NomMatiere";
            cmbMatiere.ValueMember = "Id";

            cmbProf.DataSource = cours;
            cmbProf.DisplayMember = "NomProf";
            cmbProf.ValueMember = "Id";

            //Afficher l'ID de la classe selectionnée
            cmbClasse.SelectedValue = IdClasse;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AjoutàClasse_Click(object sender, EventArgs e)
        {
            // Vérifie si tous les ComboBox ont une valeur sélectionnée
            if (cmbCours.SelectedItem != null && cmbMatiere.SelectedItem != null &&
                cmbProf.SelectedItem != null)
            {
                // Récupère les valeurs sélectionnées dans les ComboBox
                int idCours = (int)cmbCours.SelectedValue;
                int idMatiere = (int)cmbMatiere.SelectedValue;
                int idProfesseur = (int)cmbProf.SelectedValue;

                // Crée une nouvelle association entre la Classe et le Cours (relation N:N entre Classes et Cours)
                ClassesCours classesCours = new ClassesCours
                {
                    IdClasse = IdClasse,  // Lien vers la classe
                    IdCours = idCours     // Lien vers le cours
                };
                _context.ClassesCours.Add(classesCours);  // Ajoute cette association à la table ClassesCours

                // Crée une nouvelle association entre le Cours et la Matière (relation N:N entre Cours et Matières)
                CoursMatieres coursMatieres = new CoursMatieres
                {
                    IdCours = idCours,     // Lien vers le cours
                    IdMatiere = idMatiere  // Lien vers la matière
                };
                _context.CoursMatieres.Add(coursMatieres);  // Ajoute cette association à la table CoursMatieres

                // Crée une nouvelle association entre le Professeur et la Matière (relation N:N entre Professeurs et Matières)
                ProfesseursMatieres profMatieres = new ProfesseursMatieres
                {
                    IdProfesseur = idProfesseur, // Lien vers le professeur
                    IdMatiere = idMatiere        // Lien vers la matière
                };
                _context.ProfesseursMatieres.Add(profMatieres);  // Ajoute cette association à la table ProfesseursMatieres

                // Crée une nouvelle association entre le Professeur et la Classe (relation N:N entre Professeurs et Classes)
                ProfesseursClasses profClasses = new ProfesseursClasses
                {
                    IdProfesseur = idProfesseur,  // Lien vers le professeur
                    IdClasse = IdClasse          // Lien vers la classe
                };
                _context.ProfesseursClasses.Add(profClasses);  // Ajoute cette association à la table ProfesseursClasses

                // Sauvegarde les modifications dans la base de données
                _context.SaveChanges();

                // Affiche un message de succès à l'utilisateur
                MessageBox.Show("Cours, Matière et Professeur associés à la classe avec succès !");
            }
            else
            {
                // Si un des champs n'est pas rempli, affiche un message d'erreur
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }
    }
}
