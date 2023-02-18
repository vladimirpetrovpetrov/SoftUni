using System;

namespace Task._Dog_Meeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Sharo");
            Dog dog2 = new Dog("Rex");
            Dog dog3 = new Dog();
            Dog[] dogs = {dog1,dog2,dog3};
            foreach (var item in dogs)
            {
                item.Bark();
            }
        }
    }
    public class Dog
    {
        private string name = null;

        public Dog(string name)
        {
            this.name = name;
        }
        public Dog()
        {

        }
        public void Bark()
        {
            Console.WriteLine($"{this.name}: Wooof Wooof");
        }
    }
}
