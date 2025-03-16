using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Système_de_Gestion_des_Étudiants
{
     class ProfesseursClasses
    {
        // Définir une clé primaire composite avec IdProfesseur et IdClasse
        [Key, Column(Order = 0)]  // Définir IdProfesseur comme une partie de la clé primaire
        public int IdProfesseur { get; set; }
        public Professeur Professeur { get; set; }  // Propriété de navigation pour Professeur

        [Key, Column(Order = 1)]  // Définir IdClasse comme une autre partie de la clé primaire
        public int IdClasse { get; set; }
        public Classe Classe { get; set; }  // Propriété de navigation pour Classe
    }
}
