using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temp = double.Parse(Console.ReadLine());
            if (temp >= 5 && temp <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (temp >= 12 && temp <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (temp >= 15 && temp <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (temp >= 20.1 && temp <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (temp >= 26 && temp <= 35)
            {
                Console.WriteLine("Hot");
            }
            else
            {
                Console.WriteLine("unknown");
            }





        }
    }
}
