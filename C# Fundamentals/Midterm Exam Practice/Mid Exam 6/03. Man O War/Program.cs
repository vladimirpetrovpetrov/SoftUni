using System;
using System.Linq;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var statusP = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var statusW = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxHp = int.Parse(Console.ReadLine());

            while (true)
            {
                var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "Retire")
                {
                    break;
                }
                if (command[0] == "Fire")
                {
                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);
                    if(index>=0&& index<=statusW.Count-1) 
                    {
                        statusW[index] -= damage;
                        if(statusW[index]<= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if(command[0] == "Defend")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int damage = int.Parse(command[3]);
                    bool startCheck = startIndex >= 0 && startIndex <= statusP.Count - 1 && startIndex < endIndex;
                    bool endCheck = endIndex > 0 && endIndex <= statusP.Count - 1 && endIndex > startIndex;
                    if(startCheck && endCheck)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            statusP[i] -= damage;
                            if (statusP[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                    
                }
                else if (command[0] == "Repair")
                {
                    int index = int.Parse(command[1]);
                    int damage = int.Parse(command[2]);
                    if(index>=0 && index <=statusP.Count-1)
                    {
                        statusP[index] += damage;
                        if (statusP[index] > maxHp)
                        {
                            statusP[index] = maxHp;
                        }
                    }
                }
                else if (command[0] == "Status")
                {
                    int count = 0;
                    foreach (var item in statusP)
                    {
                        if (item < maxHp * 0.20)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"{count} sections need repair.");
                }
            }
            Console.WriteLine($"Pirate ship status: {statusP.Sum()}");
            Console.WriteLine($"Warship status: {statusW.Sum()}");
        }
    }
}
