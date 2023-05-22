﻿
using P_02FootballBetting.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace P02_FootballBetting.Data.Models;

public class Country
{
    public Country()
    {
        this.Towns = new HashSet<Town>();
    }

    [Key]
    public int CountryId { get; set; }

    [MaxLength(ValidationConstants.CountryNameMaxLength)]
    public string Name { get; set; } = null!;

    public virtual ICollection<Town> Towns { get; set; }
}