using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models;

public abstract class Bird : Animal, IBird
{
    protected Bird(string name, double weight, double wingSize) : base(name, weight)
    {
        this.WingSize = wingSize;
    }

    public double WingSize { get; protected set; }
    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}
