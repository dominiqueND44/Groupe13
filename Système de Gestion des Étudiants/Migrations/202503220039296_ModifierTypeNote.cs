namespace Système_de_Gestion_des_Étudiants.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class ModifierTypeNote : DbMigration
    {
        public override void Up()
        {
            // Modifier la colonne "Notes" pour la convertir en FLOAT (Single)
            AlterColumn("dbo.Notes", "Notes", c => c.Single(nullable: false));
        }

        public override void Down()
        {
            // Revenir à l'ancien type (si c'était par exemple une chaîne de caractères)
            AlterColumn("dbo.Notes", "Notes", c => c.String());
        }
    }
}
