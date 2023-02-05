using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._Array_Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubles= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Console.WriteLine($"Min = {doubles.Min()}");
            Console.WriteLine($"Max = {doubles.Max()}");
            Console.WriteLine($"Sum = {doubles.Sum()}");
            Console.WriteLine($"Average = {doubles.Average()}");
        }
    }
}

