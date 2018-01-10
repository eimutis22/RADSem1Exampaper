namespace Sem1Exampaper.Migrations.ApplicationMigrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Sem1Exampaper.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sem1Exampaper.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationMigrations";
        }

        protected override void Seed(Sem1Exampaper.Models.ApplicationDbContext context)
        {
            var manager =
                 new UserManager<ApplicationUser>(
                     new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

            roleManager.Create(new IdentityRole { Name = "Lecturer" });
            roleManager.Create(new IdentityRole { Name = "Student" });



            //ApplicationUser lecturer = manager.FindById("S001");
            //if (lecturer != null)
            //{
            //    manager.AddToRoles(lecturer.Id, new string[] { "Lecturer" });
            //}
            //else
            //{
            //    throw new Exception { Source = "Did not find user" };
            //}

            //ApplicationUser member = manager.FindByEmail("blogs.joe@itsligo.ie");
            //if (member != null)
            //{
            //    manager.AddToRoles(member.Id, new string[] { "Member" });
            //}
            //else
            //{
            //    throw new Exception { Source = "Did not find user" };
            //}
        }
    }
}
