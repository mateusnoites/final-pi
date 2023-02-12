namespace FinalPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tipo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Publicacaos", "TipoArquivo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Publicacaos", "TipoArquivo");
        }
    }
}
