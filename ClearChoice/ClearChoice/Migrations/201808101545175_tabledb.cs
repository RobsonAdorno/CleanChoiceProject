namespace ClearChoice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tabledb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Login = c.String(),
                        Senha = c.String(),
                        Nome = c.String(),
                        RG = c.String(),
                        CNPJ = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
