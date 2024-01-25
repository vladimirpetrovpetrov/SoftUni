using System;

namespace _05._Digits
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstDigit = n / 100;
            int secondDigit = n % 100 / 10;
            int thirdDigit = n % 10;
            int rows = firstDigit + secondDigit; 
            int cols = firstDigit + thirdDigit; 

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                    }
                    else
                    {
                        n += thirdDigit;
                    }
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
