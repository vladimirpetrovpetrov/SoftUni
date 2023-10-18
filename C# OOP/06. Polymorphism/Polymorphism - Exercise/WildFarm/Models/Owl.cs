using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models;

public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Hoot Hoot");
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
            this.Weight += 0.25 * FoodEaten;
        }
    }
}
