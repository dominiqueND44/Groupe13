using System;
using System.Linq;
using System.Windows.Forms;

namespace Système_de_Gestion_des_Étudiants
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Vérifier si des utilisateurs existent, sinon les créer
          /*  using (var db = new DBGestionContext())
            {
                // Vérifier si des utilisateurs existent
                if (!db.Utilisateurs.Any())
                {
                    // Ajout d'utilisateurs par défaut
                    var utilisateur1 = new Utilisateur
                    {
                        NomUtilisateur = "admin",
                        MotDePasse = BCrypt.Net.BCrypt.HashPassword("Admin123"), // Assure-toi de hasher le mot de passe
                        Role = "Administrateur",
                        Telephone = "+221770279585" // Numéro de téléphone pour l'A2F
                    };

                    var utilisateur2 = new Utilisateur
                    {
                        NomUtilisateur = "prof1",
                        MotDePasse = BCrypt.Net.BCrypt.HashPassword("Prof123"),
                        Role = "Professeur",
                        Telephone = "+221771678489"
                    };

                    var utilisateur3 = new Utilisateur
                    {
                        NomUtilisateur = "agent1",
                        MotDePasse = BCrypt.Net.BCrypt.HashPassword("Agent123"),
                        Role = "Agent",
                        Telephone = "+221770279587"
                    };

                    var utilisateur4 = new Utilisateur
                    {
                        NomUtilisateur = "de1",
                        MotDePasse = BCrypt.Net.BCrypt.HashPassword("DE123"),
                        Role = "DE",
                        Telephone = "+221770279588"
                    };

                    db.Utilisateurs.Add(utilisateur1);
                    db.Utilisateurs.Add(utilisateur2);
                    db.Utilisateurs.Add(utilisateur3);
                    db.Utilisateurs.Add(utilisateur4);
                    db.SaveChanges(); // Sauvegarde dans la base de données
                    Console.WriteLine("Utilisateurs par défaut ajoutés !");
                }
                else
                {
                    Console.WriteLine("Les utilisateurs existent déjà.");
                }
            }
          */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new loginForm());  // Ouvre directement le formulaire de connexion
             Application.Run(new NotesForm());  // 
        }
    }
}
