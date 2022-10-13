using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DGLI.PrisonVan.Data;

public class UnitOfWork : DbContext, IUnitOfWork
{
    public UnitOfWork(): base()
    {

    }
    public UnitOfWork(DbContextOptions<UnitOfWork> dbContextOptions) : base(dbContextOptions)
    {

    }
    public DbSet<Soundcard> Soundcards { get; set; }
    public DbSet<SoundFile> SoundFiles { get; set; }
    DatabaseFacade IUnitOfWork.Database => Database;
}
