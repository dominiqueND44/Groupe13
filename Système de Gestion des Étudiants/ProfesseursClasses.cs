using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Système_de_Gestion_des_Étudiants
{
    class ProfesseursClasses // Classe de l'entité de jointure ProfesseursClasses
    {

        [Key]
        public int Id { get; set; }  // Clé primaire, qui pourrait être générée automatiquement

        [ForeignKey("Professeur")]  // Spécifier que IdProfesseur est une clé étrangère
        public int IdProfesseur { get; set; }
        public Professeur Professeur { get; set; }  // Propriété de navigation pour Professeur

       
        [ForeignKey("Classe")]  // Spécifier que IdClasse est une clé étrangère
        public int IdClasse { get; set; }
        public Classe Classe { get; set; }  // Propriété de navigation pour Classe
    }
}
