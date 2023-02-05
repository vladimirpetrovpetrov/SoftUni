using System;
using System.Linq;

namespace _11._Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if (array.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            int lSum = 0;
            int rSum = 0;
            for (int posATM = 0; posATM < array.Length; posATM++)
            {
                for (int left = 0; left < posATM; left++)
                {
                    lSum += array[left];
                }

                for (int right = posATM+1; right < array.Length; right++)
                {
                    rSum += array[right];
                }

                if(lSum == rSum)
                {
                    Console.WriteLine(posATM);
                    return;
                }
                else
                {
                    lSum = 0;
                    rSum=0;
                }
            }
            Console.WriteLine("no");
        }
    }
}
