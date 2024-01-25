using System;
using System.Linq;

namespace Are_the_arrays_equal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("First array length: ");
            var firstArrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Second array length: ");
            var secondArrayLength = int.Parse(Console.ReadLine());
            if (firstArrayLength != secondArrayLength)
            {
                Console.WriteLine("They are NOT equal.");
                return;
            }
            bool areEqual = true;
            Console.WriteLine($"Fill in {firstArrayLength} elements with spaces for the first array: ");
            var firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine($"Fill in {secondArrayLength} elements with spaces for the first array: ");
            var secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                }
            }
            if (areEqual)
            {
                Console.WriteLine("They are equal.");
            }
            else
            {
                Console.WriteLine("They are NOT equal.");
            }


        }
    }
}
