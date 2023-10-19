using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl;

public class Citizen : IIdentifiable
{
    public Citizen(string id)
    {
        Id = id;
    }

    public string Id { get; set; }
}
