using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces
{
    internal interface IPrivate : ISoldier
    {
        public decimal Salary { get; }
    }
}
