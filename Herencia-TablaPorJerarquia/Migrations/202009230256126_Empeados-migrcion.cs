namespace Herencia_TablaPorJerarquia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empeadosmigrcion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpleadoInterno",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FechaContratacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleadoes", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.EmpleadoExterno",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NombreConsultor = c.String(nullable: false, maxLength: 100, unicode: false),
                        ExpiracionContacto = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleadoes", t => t.Id)
                .Index(t => t.Id);
            
            DropColumn("dbo.Empleadoes", "NombreConsultor");
            DropColumn("dbo.Empleadoes", "ExpiracionContacto");
            DropColumn("dbo.Empleadoes", "FechaContratacion");
            DropColumn("dbo.Empleadoes", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleadoes", "Type", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AddColumn("dbo.Empleadoes", "FechaContratacion", c => c.DateTime());
            AddColumn("dbo.Empleadoes", "ExpiracionContacto", c => c.DateTime());
            AddColumn("dbo.Empleadoes", "NombreConsultor", c => c.String());
            DropForeignKey("dbo.EmpleadoExterno", "Id", "dbo.Empleadoes");
            DropForeignKey("dbo.EmpleadoInterno", "Id", "dbo.Empleadoes");
            DropIndex("dbo.EmpleadoExterno", new[] { "Id" });
            DropIndex("dbo.EmpleadoInterno", new[] { "Id" });
            DropTable("dbo.EmpleadoExterno");
            DropTable("dbo.EmpleadoInterno");
        }
    }
}
