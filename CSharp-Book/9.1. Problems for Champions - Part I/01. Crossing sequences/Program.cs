using System;
using System.Collections.Generic;

namespace Tribonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tribunaci 
            int f1 = int.Parse(Console.ReadLine());
            int f2 = int.Parse(Console.ReadLine());
            int f3 = int.Parse(Console.ReadLine());
            //Spiral
            int begin = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            List<int> tribonacci = new List<int>() { f1, f2, f3 };
            List<int> spiral = new List<int>() { begin };
            for (int i = 0; i < tribonacci.Count; i++)
            {
                if (tribonacci[i] == spiral[0])
                {
                    Console.WriteLine(spiral[0]);
                    return;
                }
            }
            int kolkoPytiKachvaSys2 = 1;
            while (true)
            {
                tribonacci.Add(tribonacci[tribonacci.Count - 1] + tribonacci[tribonacci.Count - 2] + tribonacci[tribonacci.Count - 3]);
                int lastTribonacci = tribonacci[tribonacci.Count - 1];
                if (lastTribonacci > 1000000)
                {
                    tribonacci.RemoveAt(tribonacci.Count - 1);
                    break;
                }
            }
            if (tribonacci.Contains(begin))
            {
                Console.WriteLine(begin);
                return;
            }
            int counter = 0;
            while (true)
            {
                int lastItem = 0;
                if (spiral[spiral.Count - 1] > 1000000)
                {
                    Console.WriteLine("No");
                    return;
                }
                for (int i = 0; i < kolkoPytiKachvaSys2; i++)
                {
                    spiral[spiral.Count - 1] += step;
                }
                
                if (tribonacci.Contains(spiral[spiral.Count - 1]))
                {

                    break;
                }
                counter++;
                if (counter == 2)
                {
                    counter = 0;
                    kolkoPytiKachvaSys2++;
                }
            }
            Console.WriteLine(spiral[spiral.Count - 1]);


        }
    }
}
