using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * (this.radius * this.radius);
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }

}
