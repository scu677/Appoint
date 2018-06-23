using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Appoint.Models;
using Microsoft.EntityFrameworkCore;

namespace Appoint.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Partner_Client> Partner_Clients { get; set; }
        public DbSet<User_Client> User_Clients { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
