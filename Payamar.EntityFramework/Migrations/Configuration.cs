using System.Data.Entity.Migrations;

namespace Payamar.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Payamar.EntityFramework.PayamarDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Payamar";
        }

        protected override void Seed(Payamar.EntityFramework.PayamarDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
