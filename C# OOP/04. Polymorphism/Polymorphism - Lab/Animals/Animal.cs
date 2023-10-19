using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals;

public abstract class Animal
{
    private string name;
    private string favouriteFodd;

    protected Animal(string name, string favouriteFodd)
    {
        this.name = name;
        this.favouriteFodd = favouriteFodd;
    }

    public virtual string ExplainSelf()
        => $"I am {this.name} and my fovourite food is {this.favouriteFodd}";
    
}
