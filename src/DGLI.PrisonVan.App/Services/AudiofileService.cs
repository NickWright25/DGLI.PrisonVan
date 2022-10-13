using DGLI.PrisonVan.Data;

namespace DGLI.PrisonVan.App.Data.Services;

public class AudiofileService: IAudiofileService
{
    private readonly IUnitOfWork _unitOfWork;

    public AudiofileService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IEnumerable<SoundFile> LoadFiles()
    {
        return _unitOfWork.SoundFiles.AsEnumerable();
    }

    public async Task<IEnumerable<SoundFile>> UpdateRangeAsync(IEnumerable<SoundFile> configs)
    {
        _unitOfWork.SoundFiles.UpdateRange(configs);
        await _unitOfWork.SaveChangesAsync();
        return configs;
    }

    public async Task<SoundFile> AddAsync(SoundFile soundfile)
    {
        var addedRecord = await _unitOfWork.SoundFiles.AddAsync(soundfile);
        return await _unitOfWork.SaveChangesAsync() > 0
            ? addedRecord.Entity
            : null;
    }

    public async Task DeleteAsync(SoundFile soundfile)
    {
        _unitOfWork.SoundFiles.Remove(soundfile);
        await _unitOfWork.SaveChangesAsync();
    }
}
