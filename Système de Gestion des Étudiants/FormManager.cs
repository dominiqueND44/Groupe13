using System.Windows.Forms;
using Système_de_Gestion_des_Étudiants;

static class FormManager
{
    // Garder les formulaires comme des propriétés statiques
    public static loginForm loginForm { get; set; }
    public static DashboardForm DashboardForm { get; set; }
    public static EtudiantsForm EtudiantsForm { get; set; }
    public static CoursForm CoursForm { get; set; }
    public static ClassesForm ClassesForm { get; set; }
    public static ProfesseurForm ProfesseurForm { get; set; }
    public static NotesForm NotesForm { get; set; }
    public static OTPForm OTPForm { get; set; }
    public static MatiereForm MatiereForm { get; set; }
    public static UsersForm UsersForm { get; set; }
    public static AjoutMatieresCoursForm AjoutMatieresCoursForm { get; set; }
    public static AssociationCoursMatieresProfesseuràClasseForm AssociationCoursMatieresProfesseuràClasseForm { get; set; }
    public static AssocProfesseurClassesForm AssocProfesseurClassesForm { get; set; }
    public static AssocProfesseurMatieresForm AssocProfesseurMatieresForm { get; set; }
    public static Rapport RapportForm { get; set; }

    // Affiche le Dashboard Form en fonction du rôle de l'utilisateur
    public static void ShowDashboardForm(Utilisateur currentUser)
    {
        if (currentUser == null || string.IsNullOrEmpty(currentUser.Role))
        {
            MessageBox.Show("Erreur : Aucune information utilisateur trouvée.", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        else
        {
            MessageBox.Show("Bienvenue, " + currentUser.NomUtilisateur + " !", "Connexion réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Vérifie si le formulaire DashboardForm existe déjà et s'il est fermé (IsDisposed)
        if (DashboardForm == null || DashboardForm.IsDisposed)
        {
            // Si le formulaire est fermé ou n'existe pas encore, créez une nouvelle instance et passez le UserRole
            DashboardForm = new DashboardForm(currentUser.Role);  
        }
        else
        {
            // Si le formulaire est déjà ouvert, vous n'avez pas besoin d'en créer un nouveau
            DashboardForm.UserRole = currentUser.Role; // Mettre à jour le rôle si nécessaire
        }

        // Masquer tous les autres formulaires
        HideAllForms();

        // Afficher le formulaire Dashboard
        DashboardForm.Show();
    }

    // Masquer tous les formulaires
    private static void HideAllForms()
    {
        loginForm?.Hide();
        EtudiantsForm?.Hide();
        CoursForm?.Hide();
        ClassesForm?.Hide();
        ProfesseurForm?.Hide();
        NotesForm?.Hide();
        OTPForm?.Hide();
        MatiereForm?.Hide();
        UsersForm?.Hide();
        AssociationCoursMatieresProfesseuràClasseForm?.Hide();
        AssocProfesseurClassesForm?.Hide();
        AssocProfesseurMatieresForm?.Hide();
    }
}
