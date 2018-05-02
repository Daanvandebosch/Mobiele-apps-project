using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace TestProjectMobiele
{
    public interface IDataConnection
    {
        DbSet<Foto> Fotos { get; set; }
        DbSet<Gezin> Gezinnen { get; set; }
        DbSet<Hoek> Hoekken { get; set; }
        DbSet<Klas> Klassen { get; set; }
        DbSet<Kleuter> Kleuters { get; set; }
        DbSet<Leerkracht> Leerkrachten { get; set; }
        DbSet<School> Scholen { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
