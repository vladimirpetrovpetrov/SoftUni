using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    internal class Druid : BaseHero
    {
        private const int power = 80;

        public Druid(string name)
        : base(name, power) { }
    }
}
