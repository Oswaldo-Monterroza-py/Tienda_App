namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First_Commit1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provedors",
                c => new
                    {
                        ProvedorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Contacto = c.Single(nullable: false),
                        CorreoElectronico = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ProvedorId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 100),
                        Apellidos = c.String(nullable: false, maxLength: 100),
                        CorreoElectronico = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Provedors");
        }
    }
}
