using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Interfaces;

namespace WildFarm.Models;
public class Hen : Bird
{
    public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
    {
    }
    public override void ProduceSound()
    {
        Console.WriteLine("Cluck");
    }
    public override void Eat(IFood food)
    {
        base.Eat(food);
        this.Weight += 0.35 * FoodEaten;
    }
}
