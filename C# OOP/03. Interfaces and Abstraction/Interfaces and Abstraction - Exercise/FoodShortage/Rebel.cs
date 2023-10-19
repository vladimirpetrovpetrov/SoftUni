using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage;

public class Rebel : IBuyer
{
    public const int RebelFoodQuantity = 5;
    public Rebel(string name)
    {
        Name = name;
    }

    public int Food {get;protected set;}
    public string Name { get; protected set; }
    public int BuyFood()
    {
        this.Food += RebelFoodQuantity;
        return RebelFoodQuantity;
    }
}
