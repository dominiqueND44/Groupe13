namespace Système_de_Gestion_des_Étudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddIdClasseToProfesseursClasses : DbMigration
    {
        public override void Up()
        {
            // Si la colonne existe déjà, on ne tente pas de la supprimer.
            AddColumn("dbo.ProfesseursClasses", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ProfesseursClasses", "IdClasse", c => c.Int(nullable: false));
            AlterColumn("dbo.ProfesseursClasses", "IdProfesseur", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.ProfesseursClasses", "Id");
            CreateIndex("dbo.ProfesseursClasses", "IdProfesseur");
            CreateIndex("dbo.ProfesseursClasses", "IdClasse");
            AddForeignKey("dbo.ProfesseursClasses", "IdClasse", "dbo.Classes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProfesseursClasses", "IdProfesseur", "dbo.Professeurs", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.ProfesseursClasses", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.ProfesseursClasses", "IdClasse", "dbo.Classes");
            DropIndex("dbo.ProfesseursClasses", new[] { "IdClasse" });
            DropIndex("dbo.ProfesseursClasses", new[] { "IdProfesseur" });
            DropPrimaryKey("dbo.ProfesseursClasses");
            AlterColumn("dbo.ProfesseursClasses", "IdProfesseur", c => c.Int());
            AlterColumn("dbo.ProfesseursClasses", "IdClasse", c => c.Int());
            DropColumn("dbo.ProfesseursClasses", "Id");
            AddPrimaryKey("dbo.ProfesseursClasses", new[] { "IdProfesseur", "IdClasse" });
        }
    }
}
