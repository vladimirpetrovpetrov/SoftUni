using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories;

public class Pizza
{
    private string name;
    private Dough dough;
    private List<Topping> toppings;

    public Pizza(string name)
    {
        Name = name;
        toppings= new List<Topping>();
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public Dough Dough
    {
        get { return this.dough; }
        set { this.dough = value; }
    }
    public IReadOnlyCollection<Topping> Toppings 
        => toppings.AsReadOnly();

    public void AddTopping(Topping t)
    {
        if (this.toppings.Count <= 10)
        {
            toppings.Add(t);
        }
        else
        {
            throw new Exception("Number of toppings should be in range [0..10].");
        }
    }

    private double TotalCalories()
    {
        var totalKcalFromDough = this.dough.CalculateDoughKcal();
        var totalKcalFromTopping = 0d;
        foreach (var t in this.toppings)
        {
            totalKcalFromTopping += t.CalculateToppingKcal();
        }
        return totalKcalFromTopping + totalKcalFromDough;
    }
    //    Dough White cheWy 200 //660
    //Topping Meat 50 // 60 // 120
    //Topping Cheese 50 // 55 // 230
    //Topping meat 20 // 24 // 278
    //Topping sauce 10 // 9 // 296
    //Topping Meat 30 // 36 // 368

    public override string ToString()
    {
        return $"{this.Name} - {TotalCalories():F2} Calories.";
    }
}
