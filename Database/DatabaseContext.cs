using RoboDeApostas.Models;

namespace RoboDeApostas.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Partida> Partidas { get; set; } = default!;
        public DbSet<Liga> Liga { get; set; } = default!;
        public DbSet<LinkDaLiga> LinkDaLiga { get; set; } = default!;
        public DbSet<Surebet2Casas> Surebet2Casas {get; set;} = default!;
        public DbSet<Surebet3Casas> Surebet3Casas {get; set;} = default!;
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DatabaseContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlite(configuration.GetConnectionString("Sqlite"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Liga>()
                .HasIndex(l => l.Nome)
                .IsUnique();
            modelBuilder.Entity<LinkDaLiga>()
                .HasIndex(l => l.Link)
                .IsUnique();
        }
    }
}
