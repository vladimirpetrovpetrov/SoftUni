using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Supermarket_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var productsInfo = new Dictionary<string, List<double>>();
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "stocked")
                {
                    break;
                }
                var productName = input[0];
                var productPrice = double.Parse(input[1]);
                var productQuantity = double.Parse(input[2]);

                if(!productsInfo.ContainsKey(productName))
                {
                    productsInfo.Add(productName, new List<double> { productPrice,productQuantity });
                    var totalPriceForProduct = productPrice * productQuantity;
                    productsInfo[productName].Add(totalPriceForProduct);
                }
                else
                {
                    productsInfo[productName][1] += productQuantity;
                    if(productsInfo[productName][0] != productPrice)
                    {
                        productsInfo[productName][0] = productPrice;
                    }
                    productsInfo[productName][2] = productsInfo[productName][0] * productsInfo[productName][1];
                }
            }
            var grandTotal = 0d;
            foreach (var item in productsInfo)
            {
                Console.WriteLine($"{item.Key}: ${item.Value[0]:f2} * {item.Value[1]} = ${item.Value[2]:f2}");
                grandTotal += item.Value[2];
            }
            Console.WriteLine(new string('-',30));
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");



        }
    }
}
