using System;

namespace _04._Easter_Eggs_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var eggsFirstPlayer = int.Parse(Console.ReadLine());
            var eggsSecondPlayer = int.Parse(Console.ReadLine());
            var command = " ";
            while(command != "End" && eggsFirstPlayer>0 && eggsSecondPlayer > 0)
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine($"Player one has {eggsFirstPlayer} eggs left.");
                    Console.WriteLine($"Player two has {eggsSecondPlayer} eggs left.");
                    return;
                }
                if(command == "one")
                {
                    eggsSecondPlayer--;
                    if (eggsSecondPlayer < 1)
                    {
                        Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirstPlayer} eggs left.");
                        return;
                    }
                }else if(command == "two")
                {
                    eggsFirstPlayer--;
                    if (eggsFirstPlayer < 1)
                    {
                        Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecondPlayer} eggs left.");
                        return;
                    }
                }
            }
        }
    }
}
