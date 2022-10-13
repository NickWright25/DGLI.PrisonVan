using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace DGLI.PrisonVan.Data;

public interface IUnitOfWork
{
    DatabaseFacade Database { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    DbSet<Soundcard> Soundcards { get; set; }
    DbSet<SoundFile> SoundFiles { get; set; }
}
