namespace FinalPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Publicacaos", "Imagem", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Publicacaos", "Imagem", c => c.Binary());
        }
    }
}
