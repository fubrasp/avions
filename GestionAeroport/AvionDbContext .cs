using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestionAeroport
{
    public class AvionDbContext : DbContext
    {
        public AvionDbContext(DbContextOptions options): base(options)
        {
        }

        public DbSet<Avion> Avions { get; set; }
    }
}
