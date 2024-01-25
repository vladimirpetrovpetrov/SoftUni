using System;
using System.Runtime.CompilerServices;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var human = new Human("Ivan");
            human.SayHello();
            Human.SayHelloStatic();
        }
    }
    public class Human
    {
        private string name;
        public Human(string name)
        {
            this.name = name;
        }
        public void SayHello()
        {
            Console.WriteLine($"{this.name} said hello!");
        }
        public static void SayHelloStatic()
        {
            Console.WriteLine($"Hello!");
        }


    }
}
