using Microsoft.EntityFrameworkCore;
using TestProjectMobiele;

namespace TestProjectMobieles.Data
{
    public class DataConnection : DbContext, IDataConnection
    {
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Gezin> Gezinnen { get; set; }
        public DbSet<Hoek> Hoekken { get; set; }
        public DbSet<Klas> Klassen { get; set; }
        public DbSet<Kleuter> Kleuters { get; set; }
        public DbSet<Leerkracht> Leerkrachten { get; set; }
        public DbSet<School> Scholen { get; set; }

        private string connectionString;

        public DataConnection(string connectionString)
        {
            this.connectionString = connectionString;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
