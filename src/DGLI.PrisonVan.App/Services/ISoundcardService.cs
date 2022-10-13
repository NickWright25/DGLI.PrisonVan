using DGLI.PrisonVan.Data;

namespace DGLI.PrisonVan.App.Data.Services
{
    public interface ISoundcardService
    {
        IEnumerable<Soundcard> LoadConfigurations();
        Task<IEnumerable<Soundcard>> UpdateRangeAsync(IEnumerable<Soundcard> configs);
    }
}