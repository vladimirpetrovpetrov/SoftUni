using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree;

public class Product
{
    private string name;
    private decimal cost;

    public Product(string name,decimal cost)
    {
        this.Name = name;
        this.Cost = cost;
    }
    public string Name
    {
        get { return name; }
        private set 
        { 
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public decimal Cost 
    { 
        get { return cost; } 
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            else
            {
                this.cost = value;
            }
        }
    }

    public override string ToString()
    {
        return $"{this.Name}";
    }
}
