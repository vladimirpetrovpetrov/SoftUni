using System;

namespace static_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sharo = new Dog("sharo");
            Console.WriteLine(sharo.id);
            var rexi = new Dog("rexi");
        }
    }
    public class Dog
    {
        private static int DogId;

        public string name;
        public int id;

        static Dog()
        {
            DogId = 1;
            Console.WriteLine("Called static constructor");
        }

        public Dog(string name)
        {
            this.id = DogId++;
            this.name = name;
        }
    }
}
