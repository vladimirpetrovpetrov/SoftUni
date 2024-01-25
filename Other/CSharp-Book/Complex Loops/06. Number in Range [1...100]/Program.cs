using System;

namespace Числата_от_1_до_2_на_н_та_с_for_цикъл
{
    class Program
    {
        static void Main(string[] args)
        {


            var n = -1;
            while (true)
            {

                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n >= 1 && n <= 100)
                    {
                        Console.WriteLine($"The number is: {n}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("Try again: ");
                }

            }




        }
    }
}
