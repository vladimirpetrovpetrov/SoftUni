using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models;

public class AlbumResultModel
{
    public string AlbumName { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string ProducerName { get; set; }
    public HashSet<Song> AlbumSongs { get; set; }
    public decimal Price { get; set; }
}
