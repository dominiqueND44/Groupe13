using System;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    public partial class DashboardForm : Form
    {
        public string UserRole { get; set; }

        public DashboardForm(string userRole)
        {
            InitializeComponent();
            UserRole = userRole;  // Assurez-vous que le rôle est passé correctement
            Console.WriteLine($"UserRole set to: {UserRole}");
        }

        public void ConfigureAccessBasedOnRole()
        {
            // Afficher un message de journalisation pour vérifier que la méthode est appelée
            Console.WriteLine($"ConfigureAccessBasedOnRole called for role: {UserRole}");

            // Masquer tous les labels au départ pour éviter des restes d'état précédent
            labelGestionEtu.Visible = false;
            labelGestionProf.Visible = false;
            labelGestionNote.Visible = false;
            labelGestionClasse.Visible = false;
            label1.Visible = false;
            label6.Visible = false;
            label2.Visible = false;
            RapportClick.Visible = false;
            switch (UserRole)
            {
                case "Administrateur":
                    labelGestionEtu.Visible = true;
                    labelGestionProf.Visible = true;
                    labelGestionNote.Visible = true;
                    labelGestionClasse.Visible = true;
                    label1.Visible = true;
                    label6.Visible = true;
                    label2.Visible = true;
                    RapportClick.Visible = true;
                    break;

                case "Professeur":
                    labelGestionEtu.Visible = true;
                    labelGestionNote.Visible = true;
                    label6.Visible = true;
                    break;

                case "Agent":
                    labelGestionEtu.Visible = true;
                    labelGestionNote.Visible = true;
                    break;

                case "DE":
                    labelGestionClasse.Visible = true;
                    label1.Visible = true;
                    break;

                default:
                    MessageBox.Show("Erreur : Rôle utilisateur non défini. Accès refusé.");
                    break;
            }

            // Ajouter un log pour chaque label pour vérifier sa visibilité
            Console.WriteLine($"labelGestionEtu Visible after: {labelGestionEtu.Visible}");
            Console.WriteLine($"labelGestionProf Visible after: {labelGestionProf.Visible}");
            Console.WriteLine($"labelGestionNote Visible after: {labelGestionNote.Visible}");
            Console.WriteLine($"labelGestionClasse Visible after: {labelGestionClasse.Visible}");
            Console.WriteLine($"label1 Visible after: {label1.Visible}");
            Console.WriteLine($"label6 Visible after: {label6.Visible}");
            Console.WriteLine($"label2 Visible after: {label2.Visible}");
        }

    

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            // Vérification de la visibilité des labels avant l'exécution de la méthode
            Console.WriteLine($"labelGestionEtu Visible before: {labelGestionEtu.Visible}");
            Console.WriteLine($"labelGestionProf Visible before: {labelGestionProf.Visible}");

            // Appeler la méthode qui configure l'affichage en fonction du rôle
            ConfigureAccessBasedOnRole();
        }

        // Gestionnaires d'événements pour chaque label
        private void labelGestionEtu_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire des étudiants
            var etudiantsForm = new EtudiantsForm();
            etudiantsForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire des utilisateurs
            var usersForm = new UsersForm();
            usersForm.Show();
        }

        private void labelGestionProf_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire des professeurs
            var professeurForm = new ProfesseurForm();
            professeurForm.Show();
        }

        private void labelGestionNote_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire des notes
            var notesForm = new NotesForm();
            notesForm.Show();
        }

        private void labelGestionClasse_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire des classes
            var classesForm = new ClassesForm();
            classesForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire des cours
            var coursForm = new CoursForm();
            coursForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire des matières
            var matiereForm = new MatiereForm();
            matiereForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire de connexion et cache le formulaire actuel
            var loginForm = new loginForm();
            loginForm.Show();
            this.Hide(); // Masque le formulaire actuel
        }

        private void RapportClick_Click(object sender, EventArgs e)
        {
            var rapportForm = new Rapport();
            rapportForm.Show();

        }
    }
}
