namespace Herencia_TablaPorJerarquia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablaPorTipoConcreto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpleadoInterno", "Id", "dbo.Empleadoes");
            DropForeignKey("dbo.EmpleadoExterno", "Id", "dbo.Empleadoes");
            DropIndex("dbo.EmpleadoInterno", new[] { "Id" });
            DropIndex("dbo.EmpleadoExterno", new[] { "Id" });
            AddColumn("dbo.EmpleadoExterno", "Apellido", c => c.String());
            AddColumn("dbo.EmpleadoExterno", "Nombre", c => c.String());
            AddColumn("dbo.EmpleadoExterno", "Direccion", c => c.String());
            AddColumn("dbo.EmpleadoExterno", "Ciudad", c => c.String());
            AddColumn("dbo.EmpleadoExterno", "Region", c => c.String());
            AddColumn("dbo.EmpleadoExterno", "CodigoPostal", c => c.String());
            AddColumn("dbo.EmpleadoExterno", "Pais", c => c.String());
            AddColumn("dbo.EmpleadoInterno", "Apellido", c => c.String());
            AddColumn("dbo.EmpleadoInterno", "Nombre", c => c.String());
            AddColumn("dbo.EmpleadoInterno", "Direccion", c => c.String());
            AddColumn("dbo.EmpleadoInterno", "Ciudad", c => c.String());
            AddColumn("dbo.EmpleadoInterno", "Region", c => c.String());
            AddColumn("dbo.EmpleadoInterno", "CodigoPostal", c => c.String());
            AddColumn("dbo.EmpleadoInterno", "Pais", c => c.String());
            DropTable("dbo.Empleadoes");
        }
        
        public override void Down()
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
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.EmpleadoInterno", "Pais");
            DropColumn("dbo.EmpleadoInterno", "CodigoPostal");
            DropColumn("dbo.EmpleadoInterno", "Region");
            DropColumn("dbo.EmpleadoInterno", "Ciudad");
            DropColumn("dbo.EmpleadoInterno", "Direccion");
            DropColumn("dbo.EmpleadoInterno", "Nombre");
            DropColumn("dbo.EmpleadoInterno", "Apellido");
            DropColumn("dbo.EmpleadoExterno", "Pais");
            DropColumn("dbo.EmpleadoExterno", "CodigoPostal");
            DropColumn("dbo.EmpleadoExterno", "Region");
            DropColumn("dbo.EmpleadoExterno", "Ciudad");
            DropColumn("dbo.EmpleadoExterno", "Direccion");
            DropColumn("dbo.EmpleadoExterno", "Nombre");
            DropColumn("dbo.EmpleadoExterno", "Apellido");
            CreateIndex("dbo.EmpleadoExterno", "Id");
            CreateIndex("dbo.EmpleadoInterno", "Id");
            AddForeignKey("dbo.EmpleadoExterno", "Id", "dbo.Empleadoes", "Id");
            AddForeignKey("dbo.EmpleadoInterno", "Id", "dbo.Empleadoes", "Id");
        }
    }
}
