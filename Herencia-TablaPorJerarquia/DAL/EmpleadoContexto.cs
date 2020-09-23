using Herencia_TablaPorJerarquia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_TablaPorJerarquia.DAL
{
    public class EmpleadoContexto: DbContext
    {
        public EmpleadoContexto() : base("name=Empleados") { 
        
        }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmpleadoInternoMap());
            modelBuilder.Configurations.Add(new EmpleadoExternoMap());

            base.OnModelCreating(modelBuilder);
        }
    }


    public class EmpleadoInternoMap : EntityTypeConfiguration<EmpleadoInterno>
    {
        public EmpleadoInternoMap()
        {

            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("EmpleadoInterno");
            });

        }
    }

    public class EmpleadoExternoMap : EntityTypeConfiguration<EmpleadoExterno>
    {
        public EmpleadoExternoMap()
        {
            Map(x =>
            {
                x.MapInheritedProperties();
                x.ToTable("EmpleadoExterno");
            });

            Property(x => x.NombreConsultor).IsRequired()
                                           .HasColumnType("varchar")
                                           .HasMaxLength(100);
        }
    }

}
