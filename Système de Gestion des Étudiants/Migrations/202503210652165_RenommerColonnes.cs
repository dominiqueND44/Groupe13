namespace Système_de_Gestion_des_Étudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RenommerColonnes : DbMigration
    {
        public override void Up()
        {
            // Ajouter les nouvelles colonnes
            AddColumn("dbo.Notes", "Etudiant_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Notes", "Matiere_Id", c => c.Int(nullable: false));

            // Créer les index pour les nouvelles colonnes
            CreateIndex("dbo.Notes", "Etudiant_Id");
            CreateIndex("dbo.Notes", "Matiere_Id");

            // Ajouter les clés étrangères
            AddForeignKey("dbo.Notes", "Etudiant_Id", "dbo.Etudiants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Notes", "Matiere_Id", "dbo.Matieres", "Id", cascadeDelete: true);

            // Supprimer les anciennes colonnes
            DropColumn("dbo.Notes", "IdEtudiant");
            DropColumn("dbo.Notes", "IdMatiere");
        }

        public override void Down()
        {
            // Ajouter les anciennes colonnes en cas de rollback
            AddColumn("dbo.Notes", "IdMatiere", c => c.Int(nullable: false));
            AddColumn("dbo.Notes", "IdEtudiant", c => c.Int(nullable: false));

            // Supprimer les clés étrangères
            DropForeignKey("dbo.Notes", "Matiere_Id", "dbo.Matieres");
            DropForeignKey("dbo.Notes", "Etudiant_Id", "dbo.Etudiants");

            // Supprimer les index
            DropIndex("dbo.Notes", new[] { "Matiere_Id" });
            DropIndex("dbo.Notes", new[] { "Etudiant_Id" });

            // Supprimer les nouvelles colonnes
            DropColumn("dbo.Notes", "Matiere_Id");
            DropColumn("dbo.Notes", "Etudiant_Id");
        }
    }
}
