using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MusicHub.Data.Common;

namespace MusicHub.Data.Models;

public class Album
{
    public Album()
    {
        this.Songs = new HashSet<Song>();
    }

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(ValidationConstants.AlbumNameMaxLength)]
    public string Name { get; set; } = null!;

    [Required]
    public DateTime ReleaseDate { get; set; }

    public decimal Price { get; set; }

    [ForeignKey(nameof(Producer))]
    public int? ProducerId { get; set; } 

    public virtual Producer? Producer { get; set; }

    public virtual ICollection<Song> Songs { get; set; }
}
