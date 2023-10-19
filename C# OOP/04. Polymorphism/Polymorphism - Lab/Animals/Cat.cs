using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals;

public class Cat : Animal
{
    public Cat(string name, string favouriteFodd) : base(name, favouriteFodd)
    {
    }

    public override string ExplainSelf()
    {
        return base.ExplainSelf() + $"{Environment.NewLine}MEEOW";
    }
}
