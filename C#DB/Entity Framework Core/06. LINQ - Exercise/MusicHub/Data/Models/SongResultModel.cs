using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models;

public class SongResultModel
{
    public string SongName { get; set; }
    public string WriterName { get; set; }
    public HashSet<Performer> Performers { get; set; }
    public Producer Producer { get; set; }
    public TimeSpan Duration { get; set; }




}
