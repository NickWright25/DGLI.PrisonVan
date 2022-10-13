using DGLI.PrisonVan.Data;

namespace DGLI.PrisonVan.App.Data.Services;

public interface IAudiofileService
{
    Task<SoundFile> AddAsync(SoundFile soundfile);
    Task DeleteAsync(SoundFile soundfile);
    IEnumerable<SoundFile> LoadFiles();
    Task<IEnumerable<SoundFile>> UpdateRangeAsync(IEnumerable<SoundFile> configs);
}
