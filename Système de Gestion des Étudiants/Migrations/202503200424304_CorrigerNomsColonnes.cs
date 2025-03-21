namespace Système_de_Gestion_des_Étudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrigerNomsColonnes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Etudiants", "IdClasse", "dbo.Classes");
            DropForeignKey("dbo.ProfesseursClasses", "IdClasse", "dbo.Classes");
            DropForeignKey("dbo.Notes", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "IdEtudiant", "dbo.Etudiants");
            DropForeignKey("dbo.ProfesseursClasses", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.OTPCodes", "IdUtilisateur", "dbo.Utilisateurs");
            DropIndex("dbo.Notes", new[] { "IdEtudiant" });
            DropIndex("dbo.Notes", new[] { "IdMatiere" });
            DropIndex("dbo.Etudiants", new[] { "IdClasse" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdProfesseur" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdClasse" });
            DropIndex("dbo.OTPCodes", new[] { "IdUtilisateur" });
            DropPrimaryKey("dbo.ProfesseursMatieres");
            DropPrimaryKey("dbo.ProfesseursClasses");
            AddColumn("dbo.Notes", "Etudiant_Id", c => c.Int());
            AddColumn("dbo.Notes", "Matiere_Id", c => c.Int());
            AddColumn("dbo.Etudiants", "Classe_Id", c => c.Int());
            AddColumn("dbo.ProfesseursClasses", "Classe_Id", c => c.Int());
            AddColumn("dbo.ProfesseursClasses", "Professeur_Id", c => c.Int());
            AddColumn("dbo.OTPCodes", "Utilisateur_Id", c => c.Int());
            AlterColumn("dbo.Notes", "Notes", c => c.String());
            AddPrimaryKey("dbo.ProfesseursMatieres", new[] { "IdProfesseur", "IdMatiere" });
            AddPrimaryKey("dbo.ProfesseursClasses", new[] { "IdProfesseur", "IdClasse" });
            CreateIndex("dbo.Notes", "Etudiant_Id");
            CreateIndex("dbo.Notes", "Matiere_Id");
            CreateIndex("dbo.Etudiants", "Classe_Id");
            CreateIndex("dbo.ProfesseursClasses", "Classe_Id");
            CreateIndex("dbo.ProfesseursClasses", "Professeur_Id");
            CreateIndex("dbo.OTPCodes", "Utilisateur_Id");
            AddForeignKey("dbo.Etudiants", "Classe_Id", "dbo.Classes", "Id");
            AddForeignKey("dbo.ProfesseursClasses", "Classe_Id", "dbo.Classes", "Id");
            AddForeignKey("dbo.Notes", "Matiere_Id", "dbo.Matieres", "Id");
            AddForeignKey("dbo.Notes", "Etudiant_Id", "dbo.Etudiants", "Id");
            AddForeignKey("dbo.ProfesseursClasses", "Professeur_Id", "dbo.Professeurs", "Id");
            AddForeignKey("dbo.OTPCodes", "Utilisateur_Id", "dbo.Utilisateurs", "Id");
            DropColumn("dbo.ProfesseursMatieres", "Id");
            DropColumn("dbo.ProfesseursClasses", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProfesseursClasses", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.ProfesseursMatieres", "Id", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.OTPCodes", "Utilisateur_Id", "dbo.Utilisateurs");
            DropForeignKey("dbo.ProfesseursClasses", "Professeur_Id", "dbo.Professeurs");
            DropForeignKey("dbo.Notes", "Etudiant_Id", "dbo.Etudiants");
            DropForeignKey("dbo.Notes", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.ProfesseursClasses", "Classe_Id", "dbo.Classes");
            DropForeignKey("dbo.Etudiants", "Classe_Id", "dbo.Classes");
            DropIndex("dbo.OTPCodes", new[] { "Utilisateur_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "Professeur_Id" });
            DropIndex("dbo.ProfesseursClasses", new[] { "Classe_Id" });
            DropIndex("dbo.Etudiants", new[] { "Classe_Id" });
            DropIndex("dbo.Notes", new[] { "Matiere_Id" });
            DropIndex("dbo.Notes", new[] { "Etudiant_Id" });
            DropPrimaryKey("dbo.ProfesseursClasses");
            DropPrimaryKey("dbo.ProfesseursMatieres");
            AlterColumn("dbo.Notes", "Notes", c => c.String(nullable: false));
            DropColumn("dbo.OTPCodes", "Utilisateur_Id");
            DropColumn("dbo.ProfesseursClasses", "Professeur_Id");
            DropColumn("dbo.ProfesseursClasses", "Classe_Id");
            DropColumn("dbo.Etudiants", "Classe_Id");
            DropColumn("dbo.Notes", "Matiere_Id");
            DropColumn("dbo.Notes", "Etudiant_Id");
            AddPrimaryKey("dbo.ProfesseursClasses", "Id");
            AddPrimaryKey("dbo.ProfesseursMatieres", "Id");
            CreateIndex("dbo.OTPCodes", "IdUtilisateur");
            CreateIndex("dbo.ProfesseursClasses", "IdClasse");
            CreateIndex("dbo.ProfesseursClasses", "IdProfesseur");
            CreateIndex("dbo.Etudiants", "IdClasse");
            CreateIndex("dbo.Notes", "IdMatiere");
            CreateIndex("dbo.Notes", "IdEtudiant");
            AddForeignKey("dbo.OTPCodes", "IdUtilisateur", "dbo.Utilisateurs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfesseursClasses", "IdProfesseur", "dbo.Professeurs", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Notes", "IdEtudiant", "dbo.Etudiants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Notes", "IdMatiere", "dbo.Matieres", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfesseursClasses", "IdClasse", "dbo.Classes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Etudiants", "IdClasse", "dbo.Classes", "Id", cascadeDelete: true);
        }
    }
}
