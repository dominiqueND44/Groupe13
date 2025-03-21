using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Système_de_Gestion_des_Étudiants
{
    class Note
    {
        [Key] // Clé primaire
        public int Id { get; set; }

        [ForeignKey("Etudiant")] // Clé étrangère vers Etudiant
        public int Etudiant_Id { get; set; }

        [ForeignKey("Matiere")] // Clé étrangère vers Matiere
        public int Matiere_Id { get; set; }

        public string Notes { get; set; }

        // Propriétés de navigation
        public Etudiant Etudiant { get; set; }
        public Matiere Matiere { get; set; }
    }
}
