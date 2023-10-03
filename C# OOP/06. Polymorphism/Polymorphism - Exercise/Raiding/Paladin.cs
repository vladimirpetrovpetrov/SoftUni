using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    internal class Paladin : BaseHero
    {
        private const int power = 100;

        public Paladin(string name)
        : base(name, power) { }
    }
}
