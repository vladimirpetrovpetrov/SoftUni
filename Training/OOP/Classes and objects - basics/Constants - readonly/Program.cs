using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.DI);//8.14
            Math math = new Math(Color.Green);
            math.MI++;//1.11
            Console.WriteLine(math.color);//blue
        }
    }
    public class Math
    {
        //fields
        public const double DI = 8.14;
        public double MI = 1.11;
        public readonly Color color;
        //constructor
        public Math(Color color)
        {
            this.color = color;
            this.color = Color.Blue;
        }
    }
    //enumerator
    public enum Color
    {
        Red,
        Green,
        Blue
    }
}
