using System;

namespace _08._Increasing_Elements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int num = int.MaxValue;
            int count = 1;
            int oldCount = 0;
            for (int i = 0; i < n; i++)
            {
                int oldNum = num;
                num = int.Parse(Console.ReadLine());
                if (num > oldNum)
                {

                    count++;
                    if (count >= oldCount)
                    {
                        oldCount = count;
                    }
                }
                else
                {
                    count = 1;
                }
            }
            Console.WriteLine(Math.Max(count,oldCount));
        }
    }
}
