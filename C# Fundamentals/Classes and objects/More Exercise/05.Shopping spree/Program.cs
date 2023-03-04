using System.Text;

namespace _05.Shopping_spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            for (int i = 0; i < 2; i++)
            {

                var input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < input.Count; j++)
                {
                    if (i == 0)
                    {
                        var nextInput = input[j].Split("=", StringSplitOptions.RemoveEmptyEntries).ToList();
                        var personName = nextInput[0];
                        var personMoney = decimal.Parse(nextInput[1]);
                        Person person = new Person(personName, personMoney);
                        people.Add(person);
                    }
                    else
                    {
                        var nextInput = input[j].Split("=", StringSplitOptions.RemoveEmptyEntries).ToList();
                        var productName = nextInput[0];
                        var productCost = decimal.Parse(nextInput[1]);
                        Product product = new Product(productName, productCost);
                        products.Add(product);
                    }
                }
            }
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END")
                {
                    break;
                }
                var nameOfThePerson = input[0];
                var nameOfTheProduct = input[1];
                Person person = people.First(x => x.PersonName == nameOfThePerson);
                Product product = products.First(x => x.ProductName == nameOfTheProduct);
                person.BuyProduct(product);
            }
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Person
    {
        public Person(string personName, decimal personMoney)
        {
            PersonName = personName;
            PersonMoney = personMoney;
        }
        public void BuyProduct(Product product)
        {
            if (this.PersonMoney >= product.ProductCost)
            {
                this.PersonMoney -= product.ProductCost;
                this.BagOfProducts.Add(product);
                Console.WriteLine($"{this.PersonName} bought {product.ProductName}");
            }
            else
            {
                Console.WriteLine($"{this.PersonName} can't afford {product.ProductName}");
            }
        }
        public string PersonName { get; set; }
        public decimal PersonMoney { get; set; }
        public List<Product> BagOfProducts { get; set; } = new List<Product>();
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.Append(this.PersonName + " - ");
            if (this.BagOfProducts.Count > 0)
            {
                st.Append(string.Join(", ", BagOfProducts));
                return st.ToString().TrimEnd('\n');
            }
            else
            {
                st.Append("Nothing bought");
                return st.ToString().TrimEnd('\n');
            }
        }
    }
    public class Product
    {
        public Product(string productName, decimal productCost)
        {
            ProductName = productName;
            ProductCost = productCost;
        }

        public string ProductName { get; set; }
        public decimal ProductCost { get; set; }
        public override string ToString()
        {
            return this.ProductName;
        }
    }
}