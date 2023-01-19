using System;

namespace _04._Gifts_from_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if(i%2==0 && i % 3 == 0)
                {
                    if (i != s)
                    {
                        Console.Write($"{i} ");
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
    }
}
