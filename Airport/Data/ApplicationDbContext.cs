using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Airport.Models;

namespace Airport.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Airportt> Airportts { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TimeTable> TimeTables { get; set; }

        public DbSet<User> User { get; set; }
        public IEnumerable<object> ApplicationUser { get; internal set; }
    }
}
