using System;
namespace Extract_and_Combine
{
    internal class Program
    {

        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factoriel(number));






        }
        static long Factoriel(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            return n * Factoriel(n - 1);
        }
    }
}

