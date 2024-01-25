using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolibri kolibri = new Kolibri("Pencho",1, ColorOfFeathers.Mixed);
            Kolibri kolibri1 = new Kolibri("Gincho", 1, ColorOfFeathers.Green);
            kolibri.Introduce();
            kolibri1.Introduce();
        }
    }
    public class Kolibri
    {
        //полета
        private string name;
        private int age;
        private ColorOfFeathers colorOfFeathers;
        //Конструктор
        public Kolibri(string name,
            int age,ColorOfFeathers colorOfFeathers)
        {
            this.name = name;
            this.age = age;
            this.colorOfFeathers= colorOfFeathers;
        }
        //Метод
        public void Introduce()
        {
            Console.WriteLine($"My name is {this.name}, I am {this.age} years old and my feathers color is {this.colorOfFeathers}!");
        }
    }
    //енумератор
    public enum ColorOfFeathers
    {
        Red,
        Green,
        Yellow,
        Mixed
    }
}
