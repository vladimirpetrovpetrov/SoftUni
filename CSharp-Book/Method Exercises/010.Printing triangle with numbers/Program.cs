using System;

namespace принтиране_на_триъгълник
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }


        static void PrintTriangle(int num)
        {
            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            for (int row = num - 1; row >= 0; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
