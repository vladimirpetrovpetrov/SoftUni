using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footballers.DataProcessor.ImportDto;

public class ImportTeamDto
{
    [MinLength(3)]
    [MaxLength(40)]
    [RegularExpression(@"[a-zA-Z0-9\s\.\-]+")]
    [Required]
    public string Name { get; set; }
    [MinLength(2)]
    [MaxLength(40)]
    [Required]
    public string Nationality { get; set; }
    [Required]
    public int Trophies { get; set; }
    public int[] Footballers { get; set; }


}
