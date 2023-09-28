using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface;

public interface IResident
{
    public string Name { get;}
    public string Country { get;}
    public string GetName();
}
