using System;

namespace _03._Point_on_Segment
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var point1 = int.Parse(Console.ReadLine());
            var point2 = int.Parse(Console.ReadLine());
            var point3 = int.Parse(Console.ReadLine());


            var measure = 0;
            if (Math.Abs(point3 - point1) <= Math.Abs(point3 - point2))
            {
                measure = Math.Abs(point3 - point1);
            }
            else {measure = Math.Abs(point3 - point2); }
            if (point1 > point2)
            {
                var oldPoint2 = point2;
                point2 = point1;
                point1 = oldPoint2;
            }
            for (int i = point1; i <= point2; i++)
            {
                if (i == point3)
                {
                    Console.WriteLine("in");
                    Console.WriteLine(measure);
                    return;
                }
            }
            Console.WriteLine("out"); 
            Console.WriteLine(measure);


          
        }
    }
}
