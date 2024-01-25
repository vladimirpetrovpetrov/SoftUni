using System;

namespace Хистограма__for_цикъл_
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1Count = 0.00;
            var p2Count = 0.00;
            var p3Count = 0.00;
            var p4Count = 0.00;
            var p5Count = 0.00;

            for (int i = 0; i < n; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1Count += 1;
                }
                else if (num >= 200 && num < 400)
                {
                    p2Count += 1;
                }
                else if (num >= 400 && num < 600)
                {
                    p3Count += 1;
                }
                else if (num >= 600 && num < 800)
                {
                    p4Count += 1;
                }
                else { p5Count += 1; }

            }
            p1Count = (p1Count / n) * 100;
            Console.WriteLine(p1Count);
            p2Count = (p2Count / n) * 100;
            Console.WriteLine(p2Count);
            p3Count = (p3Count / n) * 100;
            Console.WriteLine(p3Count);
            p4Count = (p4Count / n) * 100;
            Console.WriteLine(p4Count);
            p5Count = (p5Count / n) * 100;
            Console.WriteLine(p5Count);


        }
    }
}
