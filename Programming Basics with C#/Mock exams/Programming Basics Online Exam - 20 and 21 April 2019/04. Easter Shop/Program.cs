using System;

namespace _04._Easter_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startingQuantity = int.Parse(Console.ReadLine());
            var command = " ";
            var eggsCount = 0;
            var soldEggs = 0;
            while(command!="Close")
            {
                command = Console.ReadLine();
                if (command == "Close")
                {
                    Console.WriteLine("Store is closed!");
                    Console.WriteLine($"{soldEggs} eggs sold.");
                    return;
                }
                eggsCount = int.Parse(Console.ReadLine());

                if (command == "Buy")
                {
                    if (startingQuantity < eggsCount)
                    {
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {startingQuantity}.");
                        return;
                    }
                    startingQuantity -= eggsCount;
                    
                    soldEggs += eggsCount;
                }else if(command == "Fill")
                {
                    startingQuantity += eggsCount;
                }
            }
        }
    }
}
