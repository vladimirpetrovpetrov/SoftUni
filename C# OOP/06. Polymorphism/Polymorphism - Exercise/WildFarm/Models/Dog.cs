using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models;

public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Woof!");
    }
    public override void Eat(IFood food)
    {
        if (food.GetType().Name != "Meat")
        {
            Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        else
        {
            base.Eat(food);
            this.Weight += 0.40 * FoodEaten;
        }
    }
}
