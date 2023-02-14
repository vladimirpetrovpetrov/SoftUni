using System;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main()
        {

            var list = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                var command = Console.ReadLine();
                if(command=="Go Shopping!")
                {
                    Console.WriteLine(String.Join(", ", list));
                    break;
                }
                var toDo = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (toDo[0] == "Urgent")
                {
                    if (!list.Contains(toDo[1]))
                    {
                        list.Insert(0, toDo[1]);
                    }
                }
                else if(toDo[0] == "Unnecessary")
                {
                    if (list.Contains(toDo[1]))
                    {
                        list.Remove(toDo[1]);
                    }
                }
                else if (toDo[0] == "Correct")
                {
                    if (list.Contains(toDo[1]))
                    {
                        int index = list.IndexOf(toDo[1]);
                        list[index] = toDo[2];
                    }
                }
                else if (toDo[0] == "Rearrange")
                {
                    if (list.Contains(toDo[1]))
                    {
                        string temp = toDo[1];
                        list.Remove(toDo[1]);
                        list.Add(temp);
                        
                    }
                }
                
            }
        }
    }
}
