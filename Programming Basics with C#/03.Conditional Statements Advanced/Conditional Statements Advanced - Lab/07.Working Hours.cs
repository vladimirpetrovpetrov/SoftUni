using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var n = int.Parse(Console.ReadLine());
            var day = Console.ReadLine();

            if (day == "Sunday" || (n < 10 || n > 18))
            {
                Console.WriteLine("closed");
            }
            else
            {
                Console.WriteLine("open");
            }


        }
    }
}
