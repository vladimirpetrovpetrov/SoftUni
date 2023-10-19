using BirthdayCelebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations;

public class Robot : IIdentifiable
{
    public Robot(string id)
    {
        Id = id;
    }

    public string Id { get; set; }
}
