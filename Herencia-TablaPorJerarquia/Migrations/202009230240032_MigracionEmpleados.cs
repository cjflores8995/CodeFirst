namespace Herencia_TablaPorJerarquia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracionEmpleados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Apellido = c.String(nullable: false, maxLength: 20),
                        Nombre = c.String(nullable: false, maxLength: 20),
                        Direccion = c.String(maxLength: 60),
                        Ciudad = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        CodigoPostal = c.String(maxLength: 10),
                        Pais = c.String(maxLength: 15),
                        NombreConsultor = c.String(),
                        ExpiracionContacto = c.DateTime(),
                        FechaContratacion = c.DateTime(),
                        Type = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleadoes");
        }
    }
}
