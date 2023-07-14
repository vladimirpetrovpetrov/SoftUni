using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories;

public class Topping
{
    private const double BASE_KCAL_TOP = 2.0;

    private string toppingType;
    private double grams;

    public Topping(string toppingType, double grams)
    {
        ToppingType = toppingType;
        Grams = grams;
    }

    public string ToppingType
    {
        get { return this.toppingType; }
        private set
        {
            if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            else
            {
                this.toppingType = value;
            }
        }
    }

    public double Grams
    {
        get { return grams; }
        private set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
            }
            else
            {
                this.grams = value;
            }
        }
    }


    public double CalculateToppingKcal()
    {
        double kcalPerGr = BASE_KCAL_TOP;
        switch (this.ToppingType.ToLower())
        {
            case "meat":
                kcalPerGr *= 1.2;
                break;
            case "veggies":
                kcalPerGr *= 0.8;
                break;
            case "cheese":
                kcalPerGr *= 1.1;
                break;
            case "sauce":
                kcalPerGr *= 0.9;
                break;
            default:
                break;
        }
        var result = kcalPerGr * this.Grams;
        return result;
    }
    //    Dough White cheWy 200 //330
    //Topping Meat 50 // 60
    //Topping Cheese 50 // 55
    //Topping meat 20 // 24
    //Topping sauce 10 // 9
    //Topping Meat 30 // 36

}
