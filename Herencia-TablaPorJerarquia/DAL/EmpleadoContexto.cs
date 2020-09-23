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
            modelBuilder.Configurations.Add(new EmpleadoMap());

            base.OnModelCreating(modelBuilder);
        }
    }

    public class EmpleadoMap: EntityTypeConfiguration<Empleado>
    {
        public EmpleadoMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Apellido).HasMaxLength(20).IsRequired();
            Property(x => x.Nombre).HasMaxLength(20).IsRequired();

            Property(x => x.Direccion).HasMaxLength(60);
            Property(x => x.Ciudad).HasMaxLength(15);
            Property(x => x.Region).HasMaxLength(15);
            Property(x => x.CodigoPostal).HasMaxLength(10);
            Property(x => x.Pais).HasMaxLength(15);

            Map<EmpleadoInterno>(x => x.Requires("Type")
                                        .HasValue("I")
                                        .HasColumnType("char")
                                        .HasMaxLength(1));

            Map<EmpleadoExterno>(x => x.Requires("Type")
                                        .HasValue("E"));
        }
    }
}
