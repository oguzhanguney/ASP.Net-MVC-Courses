namespace MVCOgrenciBilgiSistemi_Controller.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCOgrenciBilgiSistemi_Controller.DAL.OBSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; //ture yaptık.
            AutomaticMigrationDataLossAllowed = true; //+
            ContextKey = "MVCOgrenciBilgiSistemi_Controller.DAL.OBSContext";
        }

        protected override void Seed(MVCOgrenciBilgiSistemi_Controller.DAL.OBSContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
