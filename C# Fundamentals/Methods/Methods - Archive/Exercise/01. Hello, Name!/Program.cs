using System;

namespace _01._Hello__Name_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SayHello(Console.ReadLine()!);
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
