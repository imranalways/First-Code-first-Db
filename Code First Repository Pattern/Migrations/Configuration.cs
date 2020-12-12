namespace Code_First_Repository_Pattern.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Code_First_Repository_Pattern.Models.CFDatabaseDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Code_First_Repository_Pattern.Models.CFDatabaseDbContext";
        }

        protected override void Seed(Code_First_Repository_Pattern.Models.CFDatabaseDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
