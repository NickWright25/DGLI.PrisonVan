using DGLI.PrisonVan.Data;
using NAudio.Wave;

namespace DGLI.PrisonVan.App.Models;

internal class AudioPlaybackState
{
    internal DirectSoundOut Device { get; set; }
    internal AudioFileReader Audio { get; set; }
    internal SoundFile SoundFile { get; set; }

    internal AudioPlaybackState(DirectSoundOut device, AudioFileReader audio, SoundFile soundFile)
    {
        Device = device;
        Audio = audio;
        SoundFile = soundFile;
    }
}
