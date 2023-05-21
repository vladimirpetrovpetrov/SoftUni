using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MusicHub.Data.Common;
using System.Security.Cryptography;

namespace MusicHub.Data.Models;

public class Performer
{
    public Performer()
    {
        this.PerformerSongs = new HashSet<SongPerformer>();
    }
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(ValidationConstants.PerformerFirstNameMaxLength)]
    public string FirstName { get; set; } = null!;
    [Required]
    [MaxLength(ValidationConstants.PerformerLastNameMaxLength)]
    public string LastName { get; set; } = null!;
    public int Age { get; set; }
    public decimal NetWorth { get; set; }
    public virtual ICollection<SongPerformer> PerformerSongs { get; set; }

}
