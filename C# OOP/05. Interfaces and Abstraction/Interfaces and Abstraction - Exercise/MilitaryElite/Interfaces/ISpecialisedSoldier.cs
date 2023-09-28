using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces;

internal interface ISpecialisedSoldier : IPrivate
{
    public Corps Corp { get; }
}
