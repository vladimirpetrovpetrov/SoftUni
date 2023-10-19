using System.Data;

namespace ShoppingSpree;

public class Program
{
    static void Main()
    {
        //Initializing people
        string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        var people = new List<Person>();
        foreach (var p in peopleInput)
        {
            var name = p.Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
            var money = decimal.Parse(p.Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);
            try
            {
                Person person = new Person(name, money);
                people.Add(person);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            
        }
        //Initializing products
        string[] productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
        var products = new List<Product>();
        foreach (var p in productInput)
        {
            var name = p.Split("=", StringSplitOptions.RemoveEmptyEntries)[0];
            var cost = decimal.Parse(p.Split("=", StringSplitOptions.RemoveEmptyEntries)[1]);
            try
            {
                Product product = new Product(name, cost);
                products.Add(product);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            
        }

        var command = Console.ReadLine();
        while(command != "END")
        {

            var name = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
            var productName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];

            var person = people.FirstOrDefault(p=>p.Name == name);
            var product = products.FirstOrDefault(p=>p.Name == productName);
            if(person == null || product == null)
            {
                continue;
            }

            person.BuyProduct(product);
            command = Console.ReadLine();
        }
        foreach (var p in people)
        {
            p.ShowBag();
        }
    }
    
}