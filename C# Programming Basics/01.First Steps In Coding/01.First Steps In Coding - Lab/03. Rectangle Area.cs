using System;
namespace _01._Hello_SoftUni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            var area = a * b;
            Console.WriteLine(area);
        }
    }
}