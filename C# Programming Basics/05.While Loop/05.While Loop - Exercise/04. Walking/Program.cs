using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = " ";
            var currentDistance = 0;

            while(currentDistance < 10000)
            {
                n = Console.ReadLine();
                if(n == "Going home")
                {
                    n = Console.ReadLine();
                    currentDistance += int.Parse(n);
                    break;


                }
                currentDistance += int.Parse(n);
            }
            if (currentDistance >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{currentDistance-10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000-currentDistance} more steps to reach goal.");
            }










        }
    }
}
