using Microsoft.EntityFrameworkCore;
using NBA_project.Common.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace NBA_project.Helpers
{
    public class DataContext : DbContext
    {
        static readonly string connectionString = "server=localhost;port=3307;user=root;password=root;database=bdd_nba";

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 1, 0));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        public DbSet<Players> Players { get; set; }

        public DbSet<Teams> Teams { get; set; }

        public DbSet<Stades> Stades { get; set; }
    }
}
