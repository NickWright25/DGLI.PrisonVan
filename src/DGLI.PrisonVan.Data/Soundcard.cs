using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DGLI.PrisonVan.Data;

public class Soundcard
{
    [Key]
    public int Id { get; set; }
    public Guid ProductGuid { get; set; }
    public string ProductName { get; set; }
    public string FriendlyName { get; set; }
    public virtual List<SoundFile> SoundFiles { get; set; }
}
