using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            switch (figure)
            {
                case "square":
                    var a = double.Parse(Console.ReadLine());
                    Console.WriteLine(String.Format("{0:0.000}", (a * a)));
                    break;
                case "rectangle":
                    var b = double.Parse(Console.ReadLine());
                    var c = double.Parse(Console.ReadLine());
                    Console.WriteLine(String.Format("{0:0.000}", (b * c)));
                    break;
                case "circle":
                    var r = double.Parse(Console.ReadLine());
                    Console.WriteLine(String.Format("{0:0.000}", (Math.PI * r * r)));
                    break;
                case "triangle":
                    var d = double.Parse(Console.ReadLine());
                    var e = double.Parse(Console.ReadLine());
                    Console.WriteLine(String.Format("{0:0.000}", (d * (e / 2))));
                    break;
                default:
                    break;
            }


        }
    }
}
