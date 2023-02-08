using System;

namespace _02._Max_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a,b,c));
        }
        static int GetMax(int a,int b,int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
    }
}
