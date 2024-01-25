using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog sharo = new Dog();
            Dog rexi = new Dog("rexi");
            Dog gancho = new Dog(15, 2015);
        }
        
    }
    public class Dog
    {
        private string name;
        private int age;
        private int yearOfBirth;
        public Dog(string name):this(10,1995)
        {
            this.name = name;
        }
        public Dog() :this("Default dog name") 
        {
            this.Bark();
            if (20 > 10)
            {
                Console.WriteLine("hello");
            }
        }

        public Dog (int age , int yearOfBirth)
        {
            this.age = age;
            this.yearOfBirth = yearOfBirth;

        }

        public void Bark()
        {
            Console.WriteLine($"{this.name}: Wooof Wooof");
        }
    }


}
