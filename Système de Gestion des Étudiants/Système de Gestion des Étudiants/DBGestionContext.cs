using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Système_de_Gestion_des_Étudiants
{
    class DBGestionContext : DbContext
    {
        public DBGestionContext():base("gestionConnect")
        {
        }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Matiere> Matieres { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<OTPCode> OTPCodes { get; set; }
        public DbSet<ClassesCours> ClassesCours { get; set; }
        public DbSet<CoursMatieres> CoursMatieres { get; set; }
        public DbSet<ProfesseursMatieres> ProfesseursMatieres { get; set; }
        public DbSet<ProfesseursClasses> ProfesseursClasses { get; set; }
    }
}
