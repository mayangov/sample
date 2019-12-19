namespace Coursmanager.Migrations
{
    using Coursmanager.Migrations.Seeds;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Coursmanager.Models.CourseManagerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Coursmanager.Models.CourseManagerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            new ActionLinkCreate(context).Seed();
            new SideBarCreate(context).Seed();
            new UserCreator(context).Seed();
        }
    }
}
