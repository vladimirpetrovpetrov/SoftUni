using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> bagOfProducts;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        this.bagOfProducts = new List<Product>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (value == " ")
            {
                throw new ArgumentException("Name cannot be empty");
            }
            else
            {
                this.name = value;
            }
        }
    }
    public decimal Money
    {
        get { return money; }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            else
            {
                this.money = value;
            }
        }
    }

    public IReadOnlyCollection<Product> BagOfProducts 
        => this.bagOfProducts.AsReadOnly();

    public void BuyProduct(Product product)
    {
        if(product.Cost <= this.Money)
        {
            this.bagOfProducts.Add(product);
            this.Money -= product.Cost;
            Console.WriteLine($"{this.Name} bought {product.Name}");
        }
        else
        {
            Console.WriteLine($"{this.Name} can't afford {product.Name}");
        }
    }

    public void ShowBag()
    {
        if(this.bagOfProducts.Count > 0)
        {
            Console.WriteLine($"{this.Name} - {String.Join(", ",this.BagOfProducts)}");
        }
        else
        {
            Console.WriteLine($"{this.Name} - Nothing bought");
        }
    }
}
