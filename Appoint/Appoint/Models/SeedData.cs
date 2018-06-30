using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Appoint.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
           context.Database.Migrate();
            if (!context.User_Clients.Any())
            {
                context.User_Clients.AddRange(new User_Client { Name = "Uche", Email = "ujay.noble@gmail.com", Password = "secreat", Phone = "7099860099" },
            new User_Client { Name = "Wilson", Email = "wilson@yahoo.com", Password = "secreat1", Phone = "7099860098" },
            new User_Client { Name = "Sampson", Email = "Sampson@yahoo.com", Password = "secreat2", Phone = "7099860097" },
            new User_Client { Name = "Baban", Email = "baban@yahoo.com", Password = "secreat1", Phone = "7099860096" });
                context.SaveChanges();
            }
           
        }
    }
}
