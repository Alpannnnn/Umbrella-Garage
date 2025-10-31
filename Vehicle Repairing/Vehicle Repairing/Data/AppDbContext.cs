using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Vehicle_Repairing.Models;

namespace Vehicle_Repairing.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Damaged> Damaged { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
