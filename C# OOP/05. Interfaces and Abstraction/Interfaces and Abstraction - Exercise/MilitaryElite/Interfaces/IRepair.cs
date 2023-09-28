using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces;

internal interface IRepair
{
    public string PartName { get;}
    public int HoursWorked { get;}
}
