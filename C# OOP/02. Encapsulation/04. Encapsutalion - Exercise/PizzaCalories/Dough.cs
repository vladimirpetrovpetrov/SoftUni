using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories;

public class Dough
{
    private const double BASE_KCAL = 2.0;

    private string flourType;
    private string bakingTechnique;
    private double grams;

    public Dough(string flourType, string bakingTechnique, double grams)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Grams = grams;
    }

    public string FlourType 
    { 
        get { return flourType; }
        private set 
        { 
            if(value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            else
            {
                this.flourType = value;
            }
        }
    }
    public string BakingTechnique
    {
        get { return bakingTechnique; }
        private set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            else
            {
                this.bakingTechnique = value;
            }
        }
    }
    public double Grams
    {
        get { return grams; }
        private set
        {
            if(value <1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            else
            {
                this.grams = value;
            }
        }
    }



    public double CalculateDoughKcal()
    {//Dough Wholegrain Crispy 100
        double kcalPerGr = 0;
        if(this.FlourType.ToLower() == "white")
        {
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    kcalPerGr = 1.5 * 0.9 * BASE_KCAL;
                    break;
                case "chewy":
                    kcalPerGr = 1.5 * 1.1 * BASE_KCAL;
                    break;
                case "homemade":
                    kcalPerGr = 1.5 * 1.0 * BASE_KCAL;
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy":
                    kcalPerGr = 1.0 *0.9 * BASE_KCAL;
                    break;
                case "chewy":
                    kcalPerGr = 1.0 * 1.1 * BASE_KCAL;
                    break;
                case "homemade":
                    kcalPerGr = 1.0 * 1.0 * BASE_KCAL;
                    break;
                default:
                    break;
            }
        }
        var result = kcalPerGr * this.Grams;
        return result;
    }
    //    Dough White cheWy 200 //330 // 660
    //Topping Meat 50 // 60
    //Topping Cheese 50 // 55
    //Topping meat 20 // 24
    //Topping sauce 10 // 9
    //Topping Meat 30 // 36

}


