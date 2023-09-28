using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Interfaces
{
    internal interface ISoldier
    {
        public int Id { get;}
        public string Name { get; }
        public string LastName { get; }
    }
}
