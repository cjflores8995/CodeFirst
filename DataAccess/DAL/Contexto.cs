using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public class Contexto: DbContext
    {
        public Contexto() : base("MiBaseDeDatos") {

            Database.SetInitializer<Contexto>(new DropCreateDatabaseIfModelChanges<Contexto>());
        }

        public DbSet<Trabajos> Trabajos { get; set; }
        public DbSet<TipoContrato> TipoContratos { get; set; }
        public DbSet<CategoriasTrabajos> CategoriasTrabajos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach(var entry in this.ChangeTracker.Entries().Where(x => x.State == (EntityState)System.Data.Entity.EntityState.Added))
            {
                entry.Property("FechaRegistro").CurrentValue = DateTime.Now;
                entry.Property("FechaModificacion").CurrentValue = DateTime.Now;
                entry.Property("Estado").CurrentValue = true;
            }

            return base.SaveChanges();
        }
    }

}
