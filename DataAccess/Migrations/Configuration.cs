namespace DataAccess.Migrations
{
    using DataAccess.Models;
    using DataAccess.Seeders;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.DAL.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataAccess.DAL.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            new TipoContratoSeeder().Seed(context);

            new CategoriasTrabajosSeeder().Seed(context);
        }
    }
}
