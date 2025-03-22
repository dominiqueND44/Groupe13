namespace Système_de_Gestion_des_Étudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutdecoursdanslatablenouvelleCree : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CoursMatieresProfesseursClasses", "IdCours", c => c.Int(nullable: false));
            CreateIndex("dbo.CoursMatieresProfesseursClasses", "IdCours");
            AddForeignKey("dbo.CoursMatieresProfesseursClasses", "IdCours", "dbo.Cours", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CoursMatieresProfesseursClasses", "IdCours", "dbo.Cours");
            DropIndex("dbo.CoursMatieresProfesseursClasses", new[] { "IdCours" });
            DropColumn("dbo.CoursMatieresProfesseursClasses", "IdCours");
        }
    }
}
