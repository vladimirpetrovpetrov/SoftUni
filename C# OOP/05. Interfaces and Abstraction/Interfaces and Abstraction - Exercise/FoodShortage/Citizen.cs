using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage;

public class Citizen : IBuyer
{
    private const int CitizenFoodQuantity = 10;
    public Citizen(string name)
    {
        Name = name;
    }

    public int Food { get; protected set; }

    public string Name {get ; protected set; }  

    public int BuyFood()
    {
        this.Food += CitizenFoodQuantity;
        return CitizenFoodQuantity;
    }
}
