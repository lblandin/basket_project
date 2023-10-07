using Microsoft.EntityFrameworkCore;
using NBA_project.Common.Models;

namespace NBA_project.Helpers
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
            var serverVersion = new MySqlServerVersion(new Version(8, 1, 0));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

        public DbSet<Players> Players { get; set; }

        public DbSet<Teams> Teams { get; set; }

        public DbSet<Stades> Stades { get; set; }
    }
}
