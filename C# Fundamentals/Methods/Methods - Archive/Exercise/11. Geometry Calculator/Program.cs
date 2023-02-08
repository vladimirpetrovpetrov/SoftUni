using System;

namespace _11._Geometry_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            if (command == "triangle" || command == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalcArea(command, sideA,sideB):f2}");
            }
            else
            {
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine($"{CalcArea(command, sideA):f2}");
            }
        }
        static double CalcArea(string type, double a, double b = 0)
        {
            if(type == "triangle")
            {
                return TriangleArea(a, b);
            }else if (type == "rectangle")
            {
                return RectangleArea(a, b);
            }
            else if (type == "square")
            {
                return SquareArea(a);
            }
            else if(type == "circle")
            {
                return CircleArea(a);
            }
            return 0;
        }
        static double TriangleArea(double a , double b)
        {
            return (a * b) / 2;
        }
        static double RectangleArea(double a, double b)
        {
            return a * b;
        }
        static double SquareArea(double a)
        {
            return a*a;
        }
        static double CircleArea(double a)
        {
            return Math.PI * (a * a);
        }

    }
}
