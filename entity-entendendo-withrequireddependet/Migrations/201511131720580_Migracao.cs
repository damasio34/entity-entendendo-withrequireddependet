namespace entity_entendendo_withrequireddependet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migracao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Logradouro = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pessoa", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Endereco", "Id", "dbo.Pessoa");
            DropIndex("dbo.Endereco", new[] { "Id" });
            DropTable("dbo.Pessoa");
            DropTable("dbo.Endereco");
        }
    }
}
