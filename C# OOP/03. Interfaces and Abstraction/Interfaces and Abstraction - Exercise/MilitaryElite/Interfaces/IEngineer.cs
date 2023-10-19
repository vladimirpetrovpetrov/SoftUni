using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces;

internal interface IEngineer : ISpecialisedSoldier
{
    public IReadOnlyCollection<IRepair> Repairs { get;}
}
