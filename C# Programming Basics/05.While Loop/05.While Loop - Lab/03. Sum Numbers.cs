using System;

namespace Sum_of_numbers_While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());

            var y = int.Parse(Console.ReadLine());
            var sum = y;
            while (sum < x)
            {
                y = int.Parse(Console.ReadLine());
                sum += y;
            }
            Console.WriteLine(sum);
        }
    }
}
