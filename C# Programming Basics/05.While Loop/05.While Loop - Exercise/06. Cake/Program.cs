using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var piecesCake = length * width;
            var piecesTakenThisTime = " ";



            while(piecesCake > 0 && piecesTakenThisTime != "STOP")
            {
                piecesTakenThisTime = Console.ReadLine();
                if(piecesTakenThisTime == "STOP")
                {
                    Console.WriteLine($"{piecesCake} pieces are left.");
                    break;
                }
                piecesCake -= int.Parse(piecesTakenThisTime);
            }
            if(piecesCake< 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(piecesCake)} pieces more.");
            }
            









        }
    }
}
