namespace Système_de_Gestion_des_Étudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutCoursMatieresProfesseursClasses : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoursMatieresProfesseursClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdProfesseur = c.Int(nullable: false),
                        IdMatiere = c.Int(nullable: false),
                        IdClasse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.IdClasse, cascadeDelete: true)
                .ForeignKey("dbo.Matieres", t => t.IdMatiere, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.IdProfesseur, cascadeDelete: true)
                .Index(t => t.IdProfesseur)
                .Index(t => t.IdMatiere)
                .Index(t => t.IdClasse);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CoursMatieresProfesseursClasses", "IdProfesseur", "dbo.Professeurs");
            DropForeignKey("dbo.CoursMatieresProfesseursClasses", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieresProfesseursClasses", "IdClasse", "dbo.Classes");
            DropIndex("dbo.CoursMatieresProfesseursClasses", new[] { "IdClasse" });
            DropIndex("dbo.CoursMatieresProfesseursClasses", new[] { "IdMatiere" });
            DropIndex("dbo.CoursMatieresProfesseursClasses", new[] { "IdProfesseur" });
            DropTable("dbo.CoursMatieresProfesseursClasses");
        }
    }
}
