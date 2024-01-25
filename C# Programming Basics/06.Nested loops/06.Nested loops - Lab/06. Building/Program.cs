using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var floors = int.Parse(Console.ReadLine());

            var roomsPerFloor = int.Parse(Console.ReadLine());

            for (int floor = floors; floor >= 1; floor--)
            {

                for (int room = 0; room < roomsPerFloor; room++)
                {
                    if (floor == floors)
                    {
                        Console.Write($"L{floor}{room} ");
                    }else if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                    
                }
                Console.WriteLine();
            }









        }
    }
}
