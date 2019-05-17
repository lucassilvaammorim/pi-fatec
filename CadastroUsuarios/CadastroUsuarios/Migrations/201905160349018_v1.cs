namespace CadastroUsuarios.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cartaos",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Validade = c.DateTime(),
                        Motivo = c.String(),
                        Nascimento = c.DateTime(),
                        Cpf = c.String(),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cartaos");
        }
    }
}
