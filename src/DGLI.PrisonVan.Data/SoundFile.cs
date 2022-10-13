using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DGLI.PrisonVan.Data;

public class SoundFile
{
    [Key]
    public int Id { get; set; }
    public int Sequence { get; set; }
    public string? FileName { get; set; }
    public string? FilePath { get; set; }
    public long FileSize { get; set; }
    [NotMapped]
    public SoundFileStatus Status { get; set; }
    public int? SoundcardId { get; set; }
    public virtual Soundcard? Soundcard { get; set; }
}

public enum SoundFileStatus
{
    Pending,
    Playing,
    Paused,
    Completed
}