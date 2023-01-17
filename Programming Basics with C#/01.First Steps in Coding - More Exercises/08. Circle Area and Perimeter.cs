using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * r * r;
            var parameter = 2 * Math.PI * r;


            Console.WriteLine(String.Format("{0:0.00}", area));
            Console.WriteLine(String.Format("{0:0.00}", parameter));


        }
    }
}