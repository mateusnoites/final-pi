namespace FinalPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publicacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Conteudo = c.String(),
                        Imagem = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publicacaos");
        }
    }
}
