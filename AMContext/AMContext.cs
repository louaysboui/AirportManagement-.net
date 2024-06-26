using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure
{
        internal class AMContext : DbContext
        {
            public DbSet<Plane> Planes { get; set; }
            public DbSet<Flight> flights { get; set; }
            public DbSet<Traveller> travellers { get; set; }
            public DbSet<Staff> staffs { get; set; }
            public DbSet<Passenger> passes { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Soource=(localdb)\mssqllocaldb;
            Initial Catalog=AirportManegementDB;Integrated Security=true");
                base.OnConfiguring(optionsBuilder);
            }
        
}
