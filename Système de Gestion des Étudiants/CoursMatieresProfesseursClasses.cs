using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Système_de_Gestion_des_Étudiants;

 class CoursMatieresProfesseursClasses
{
    [Key]
    public int Id { get; set; } // Identifiant unique de l'association

    // Clé étrangère pour le Professeur
    [ForeignKey("Professeur")]
    public int IdProfesseur { get; set; }
    public virtual Professeur Professeur { get; set; } // Navigation vers l'entité Professeur

    // Clé étrangère pour la Matière
    [ForeignKey("Matiere")]
    public int IdMatiere { get; set; }
    public virtual Matiere Matiere { get; set; } // Navigation vers l'entité Matière
    [ForeignKey("Cours")]
    public int IdCours { get; set; }
    public virtual Cours Cours { get; set; } // Navigation vers l'entité Matière

    // Clé étrangère pour la Classe
    [ForeignKey("Classe")]
    public int IdClasse { get; set; }
    public virtual Classe Classe { get; set; } // Navigation vers l'entité Classe
}
