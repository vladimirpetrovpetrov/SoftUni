using System;
using System.Data;
using System.Linq;

namespace _07._Inventory_Matcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productNames = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            long[] quantitiesNew = new long[productNames.Length];
            InitQuantities(quantitiesNew);
            
            var quantities = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => long.Parse(x)).ToArray();
            Array.Copy(quantities,quantitiesNew,quantities.Length);
            //If there is less quantities than , products we assume that the quantity is 0.
            var prices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
            



            while (true)
            {
                string product = Console.ReadLine();
                if (product == "done")
                {
                    break;
                }
                var splittedProduct = product.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                long indexOfTheProduct = 0;

                for (int i = 0; i < productNames.Length; i++)
                {//finding at which index in productNames
                    if (splittedProduct[0] == productNames[i])
                    {
                        indexOfTheProduct = i;
                        break;
                    }
                }
                //now we have 3 arrays, and which index is the product
                decimal price = prices[indexOfTheProduct] * long.Parse(splittedProduct[1]);
                
                long quantity = quantitiesNew[indexOfTheProduct];
                if (quantity >= long.Parse(splittedProduct[1]))
                {
                    Console.WriteLine($"{splittedProduct[0]} x {splittedProduct[1]} costs {price:f2}");
                    quantitiesNew[indexOfTheProduct] -= long.Parse(splittedProduct[1]);

                }
                else
                {
                    Console.WriteLine($"We do not have enough {splittedProduct[0]}");
                }
            }
        }

        static void InitQuantities(long[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = 0;
            }
        }





    }
}
