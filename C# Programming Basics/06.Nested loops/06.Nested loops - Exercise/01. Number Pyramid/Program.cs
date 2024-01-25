using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            var current = 1;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(current+" ");
                    current++;
                    if (current > n)
                    {
                        return;
                    }
                }
                Console.WriteLine();
            }








        }
    }
}
