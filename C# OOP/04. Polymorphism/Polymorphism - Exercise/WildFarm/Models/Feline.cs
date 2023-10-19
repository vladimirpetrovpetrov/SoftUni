using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models;

public abstract class Feline : Mammal, IFeline
{
    public Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
    {
        Breed = breed;
    }

    public string Breed { get; protected set; }
    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
