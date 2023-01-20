using System;

namespace _11._Increasing_4_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {




            var min = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var count = 0;
            for (int d1 = min; d1 <= max - 3; d1++)
            {
                for (int d2 = min + 1; d2 <= max - 2; d2++)
                {

                    for (int d3 = min + 2; d3 <= max - 1; d3++)
                    {
                        for (int d4 = min + 3; d4 <= max; d4++)
                        {
                            if (d4 > d3 && d3 > d2 && d2 > d1)
                            {
                                count++;
                                Console.WriteLine($"{d1} {d2} {d3} {d4}");
                            }
                        }
                    }
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
