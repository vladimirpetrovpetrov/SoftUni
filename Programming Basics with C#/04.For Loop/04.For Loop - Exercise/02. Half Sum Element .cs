using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = int.Parse(Console.ReadLine());
            var sum = 0.00;
            var max = int.MinValue;
            for (int i = 0; i < nums; i++)
            {
                var x = int.Parse(Console.ReadLine());
                sum += x;

                if (max < x)
                {
                    max = x;
                }

            }
            if (max == sum / 2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", Math.Abs(max - (sum - max)));
            }
        }
    }
}
