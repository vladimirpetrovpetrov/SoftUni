using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models;

public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Meow");
    }
    public override void Eat(IFood food)
    {
        if (food.GetType().Name != "Vegetable" &&
            food.GetType().Name != "Meat")
        {
            Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
        else
        {
            base.Eat(food);
            this.Weight += 0.30*FoodEaten;
        }
    }
}
