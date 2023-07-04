using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caravan.Models;
using Microsoft.EntityFrameworkCore;

namespace Caravan.Data
{
    public class CaravanContext : DbContext
    {
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Wagon> Wagons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
            .UseNpgsql("Host=localhost;Username=postgres;Password=password123;Database=Caravan")
            .UseSnakeCaseNamingConvention();
    }
}
