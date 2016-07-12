namespace JMLoc15.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    internal sealed class Configuration : DbMigrationsConfiguration<JMLoc15Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JMLoc15Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Configuration.AutoDetectChangesEnabled = true;

            AddUserAndRole(context);

            List<Users> users = context.Users.ToList();
            context.Users.RemoveRange(users);
            context.Users.AddOrUpdate(
              p => p.Id,
              new Users { Id = Guid.NewGuid().ToString(), Name = "Erick Steven", LastName = "Velasco Amaya", Password = "Erick.123" },
              new Users { Id = Guid.NewGuid().ToString(), Name = "Brayan Sneider", LastName = "Silva Torres", Password = "Brayan.123" }
            );
            List<Lines> lines = context.Lines.ToList();
            context.Lines.RemoveRange(lines);
            context.Lines.AddOrUpdate(
              p => p.Id,
              new Lines { Id = Guid.NewGuid().ToString(), Name = "Pol�tica", Description = "Estrategia del panal, representaci�n pol�tica y leyes pro juventud." },
              new Lines { Id = Guid.NewGuid().ToString(), Name = "Trabajo social", Description = "Enfocado a poblaciones espec�ficas." },
              new Lines { Id = Guid.NewGuid().ToString(), Name = "Labor comunitaria", Description = "Para la comunidad en general, por tem�ticas." },
              new Lines { Id = Guid.NewGuid().ToString(), Name = "Motivaci�n", Description = "Nuestra formaci�n como j�venes del Movimiento." },
              new Lines { Id = Guid.NewGuid().ToString(), Name = "Free time", Description = "El buen aprovechamiento del tiempo libre." },
              new Lines { Id = Guid.NewGuid().ToString(), Name = "Comunicaci�n", Description = "Vender la marca del Movimiento y de nuestras actividades" },
              new Lines { Id = Guid.NewGuid().ToString(), Name = "Decoraci�n", Description = "Linea transversal a todas." },
              new Lines { Id = Guid.NewGuid().ToString(), Name = "Autsostenimiento", Description = "Como nosotros mismos nos ayudamos para ayudar a todos." }
            );

        }
        bool AddUserAndRole(JMLoc15Context context)
        {
            IdentityResult ir;
            var rm = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            ir = rm.Create(new IdentityRole("canEdit"));
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var user = new ApplicationUser()
            {
                UserName = "user1@contoso.com",
            };
            ir = um.Create(user, "P_assw0rd1");
            if (ir.Succeeded == false)
                return ir.Succeeded;
            ir = um.AddToRole(user.Id, "canEdit");
            return ir.Succeeded;
        }
    }
}
