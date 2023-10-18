using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models;

public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Squeak");
    }
    public override void Eat(IFood food)
    {
        if (food.GetType().Name != "Vegetable" &&
            food.GetType().Name != "Fruit")
        {
            Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        else
        {
            base.Eat(food);
            this.Weight += 0.10 * FoodEaten;
        }
    }
}
