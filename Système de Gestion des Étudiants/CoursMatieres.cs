using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Système_de_Gestion_des_Étudiants;

class CoursMatieres
{
    [Key]
    public int Id { get; set; }  // Clé primaire, qui pourrait être générée automatiquement

    // Clé étrangère vers la table Cours
    [ForeignKey("Cours")]
    public int IdCours { get; set; }
    public Cours Cours { get; set; }

    // Clé étrangère vers la table Matiere
    [ForeignKey("Matiere")]
    public int IdMatiere { get; set; }
    public Matiere Matiere { get; set; }
}
