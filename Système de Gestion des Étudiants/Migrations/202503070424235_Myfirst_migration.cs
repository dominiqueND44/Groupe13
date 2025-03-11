namespace Système_de_Gestion_des_Étudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Myfirst_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClassesCours",
                c => new
                    {
                        IdClasse = c.Int(nullable: false, identity: true),
                        IdCours = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                        Cours_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdClasse)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .Index(t => t.Classe_Id)
                .Index(t => t.Cours_Id);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomCours = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoursMatieres",
                c => new
                    {
                        IdCours = c.Int(nullable: false, identity: true),
                        IdMatiere = c.Int(nullable: false),
                        Cours_Id = c.Int(),
                        Matiere_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdCours)
                .ForeignKey("dbo.Cours", t => t.Cours_Id)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id)
                .Index(t => t.Cours_Id)
                .Index(t => t.Matiere_Id);
            
            CreateTable(
                "dbo.Matieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomMatiere = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEtudiant = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        Notes = c.String(),
                        Etudiant_Id = c.Int(),
                        Matiere_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Etudiants", t => t.Etudiant_Id)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id)
                .Index(t => t.Etudiant_Id)
                .Index(t => t.Matiere_Id);
            
            CreateTable(
                "dbo.Etudiants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricule = c.String(),
                        Nom = c.String(),
                        Prenom = c.String(),
                        DateNaissance = c.DateTime(nullable: false),
                        sexe = c.String(),
                        Adresse = c.String(),
                        Telephone = c.String(),
                        Email = c.String(),
                        IdClasse = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .Index(t => t.Classe_Id);
            
            CreateTable(
                "dbo.ProfesseursMatieres",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false, identity: true),
                        IdMatiere = c.Int(nullable: false),
                        Matiere_Id = c.Int(),
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdProfesseur)
                .ForeignKey("dbo.Matieres", t => t.Matiere_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Matiere_Id)
                .Index(t => t.Professeur_Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        Email = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfesseursClasses",
                c => new
                    {
                        IdProfesseur = c.Int(nullable: false, identity: true),
                        IdClasse = c.Int(nullable: false),
                        Classe_Id = c.Int(),
                        Professeur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdProfesseur)
                .ForeignKey("dbo.Classes", t => t.Classe_Id)
                .ForeignKey("dbo.Professeurs", t => t.Professeur_Id)
                .Index(t => t.Classe_Id)
                .Index(t => t.Professeur_Id);
            
            CreateTable(
                "dbo.OTPCodes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUtilisateur = c.Int(nullable: false),
                        Code = c.String(),
                        DateExpiration = c.DateTime(nullable: false),
                        Utilisateur_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_Id)
                .Index(t => t.Utilisateur_Id);
            
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomUtilisateur = c.String(),
                        MotDePasse = c.String(),
                        Role = c.String(),
                        Telephone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OTPCodes", "Utilisateur_Id", "dbo.Utilisateurs");
            DropForeignKey("dbo.ProfesseursMatieres", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.ProfesseursMatieres", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "Etudiant_Id", "dbo.Etudiants");
            DropForeignKey("dbo.Etudiants", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.CoursMatieres", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.ClassesCours", "Classe_Id", "dbo.Classes");
            DropIndex("dbo.OTPCodes", new[] { "Utilisateur_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "Classe_Id" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseursMatieres", new[] { "Matiere_Id" });
            DropIndex("dbo.Etudiants", new[] { "Classe_Id" });
            DropIndex("dbo.Notes", new[] { "Matiere_Id" });
            DropIndex("dbo.Notes", new[] { "Etudiant_Id" });
            DropIndex("dbo.CoursMatieres", new[] { "Matiere_Id" });
            DropIndex("dbo.CoursMatieres", new[] { "Cours_Id" });
            DropIndex("dbo.ClassesCours", new[] { "Cours_Id" });
            DropIndex("dbo.ClassesCours", new[] { "Classe_Id" });
            DropTable("dbo.Utilisateurs");
            DropTable("dbo.OTPCodes");
            DropTable("dbo.ProfesseursClasses");
            DropTable("dbo.Professeurs");
            DropTable("dbo.ProfesseursMatieres");
            DropTable("dbo.Etudiants");
            DropTable("dbo.Notes");
            DropTable("dbo.Matieres");
            DropTable("dbo.CoursMatieres");
            DropTable("dbo.Cours");
            DropTable("dbo.ClassesCours");
            DropTable("dbo.Classes");
        }
    }
}
