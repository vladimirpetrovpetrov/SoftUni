using System;
using System.Linq;

namespace _07._Inventory_Matcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var quantities = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray();
            var prices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            while(true) 
            {
                string product = Console.ReadLine();
                if(product == "done")
                {
                    break;
                }
                int indexOfTheProduct = 0;
                
                for (int i = 0; i < productNames.Length; i++)
                {//finding at which index is the product in all arrays
                    if(product == productNames[i]) 
                    {
                        indexOfTheProduct = i;
                    }
                }
                decimal price = prices[indexOfTheProduct];
                long quantity = quantities[indexOfTheProduct];
                Console.WriteLine($"{product} costs: {price}; Available quantity: {quantity}");
            }
        }
    }
}
