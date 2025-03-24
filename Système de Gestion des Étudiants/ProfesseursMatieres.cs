using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Système_de_Gestion_des_Étudiants
{
     class ProfesseursMatieres
    {
        // Définir une clé primaire composite avec IdProfesseur et IdMatiere
        [Key, Column(Order = 0)]  // Définir IdProfesseur comme une partie de la clé primaire
        public int IdProfesseur { get; set; }

        [ForeignKey("IdProfesseur")]  // Spécifier que IdProfesseur est une clé étrangère vers Professeur
        public Professeur Professeur { get; set; }  // Propriété de navigation pour Professeur

        [Key, Column(Order = 1)]  // Définir IdMatiere comme une autre partie de la clé primaire
        public int IdMatiere { get; set; }

        [ForeignKey("IdMatiere")]  // Spécifier que IdMatiere est une clé étrangère vers Matière
        public Matiere Matiere { get; set; }  // Propriété de navigation pour Matière
    }
}
