using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Système_de_Gestion_des_Étudiants;

 class ClassesCours
{
    [Key]
    public int Id { get; set; }  // Clé primaire de la table de jointure

    // Clé étrangère vers la table Classe
    [ForeignKey("Classe")]
    public int IdClasse { get; set; }
    public Classe Classe { get; set; }

    // Clé étrangère vers la table Cours
    [ForeignKey("Cours")]
    public int IdCours { get; set; }
    public Cours Cours { get; set; }
}
