using System;

namespace Training
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = int.Parse(Console.ReadLine());
            if ((x >= 100 && x <= 200) || x == 0)
            {
                Console.WriteLine();
            }
            else { Console.WriteLine("invalid"); }




        }
    }
}
