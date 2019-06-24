namespace Appstore.DataSqlite.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity.Migrations;
    using System.Data.SQLite.EF6.Migrations;
 
    using Appstore.Models;




    internal sealed class AppstoreConfiguration : DbMigrationsConfiguration<Appstore.DataSqlite.AppstoreContext>
    {
        public AppstoreConfiguration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            SetSqlGenerator("System.Data.SQLite", new SQLiteMigrationSqlGenerator());

        }
        protected override void Seed(Appstore.DataSqlite.AppstoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            if (context.Devs.Any())
                return;

            var microsoft = new Dev { Name = "Microsoft" };
            var apple = new Dev { Name = "Apple" };
            var games = new Category { Name = "Games" };


            microsoft.Apps.Add(new App { Name = "Office" });
            microsoft.Apps.Add(new App { Description = "Suite Office incluant Word, PowerPoint et Excel" });
            microsoft.Apps.Add(new App { Price = 399 });
            microsoft.Apps.Add(new App { Downloads = 4000000 });
           
            apple.Apps.Add(new App { Name = "Itunes" });
            apple.Apps.Add(new App { Description = "Logiciel permettant de stream et download de la musique" });
            apple.Apps.Add(new App { Price = 0 });
            apple.Apps.Add(new App { Downloads = 5982982 });

            games.Apps.Add(new App { Name = "Call of duty"});
            games.Apps.Add(new App { Description = "First person shooter" });
            games.Apps.Add(new App { Price = 70 });
            games.Apps.Add(new App { Downloads = 90000000 });

            
            context.Devs.Add(microsoft);
            context.Devs.Add(apple);
            context.Categories.Add(games);

        }
    }

}
