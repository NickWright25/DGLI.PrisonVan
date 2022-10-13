using DGLI.PrisonVan.Data;

namespace DGLI.PrisonVan.App.Data.Services;

public class SoundcardService : ISoundcardService
{
    private readonly IUnitOfWork _unitOfWork;

    public SoundcardService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<Soundcard> LoadConfigurations()
    {
       return _unitOfWork.Soundcards.AsEnumerable();
    }

    public async Task<IEnumerable<Soundcard>> UpdateRangeAsync(IEnumerable<Soundcard> configs)
    {
        _unitOfWork.Soundcards.UpdateRange(configs);
        await _unitOfWork.SaveChangesAsync();
        return configs;
    }
}
