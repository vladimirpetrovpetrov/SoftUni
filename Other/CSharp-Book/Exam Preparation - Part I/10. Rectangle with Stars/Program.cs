using System;

namespace _10._Rectangle_with_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            //първи ред
            Console.WriteLine(new string('%', 2 * n));
            //горна част
            for (int row = 1; row <= (n - 1) / 2; row++)
            {
                Console.Write("%");
                for (int i = 0; i < 2 * n - 2; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("%");
                Console.WriteLine();
            }
            //среден ред
            Console.Write("%");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("**");
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("%");
            Console.WriteLine();
            //долна част
            for (int row = 1; row <= (n - 1) / 2; row++)
            {
                Console.Write("%");
                for (int i = 0; i < 2 * n - 2; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("%");
                Console.WriteLine();
            }
            //последен ред
            Console.WriteLine(new string('%', 2 * n));



        }
    }
}
