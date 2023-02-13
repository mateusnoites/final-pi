namespace FinalPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Data : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Publicacaos", "DataPostagem", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Publicacaos", "DataPostagem");
        }
    }
}
