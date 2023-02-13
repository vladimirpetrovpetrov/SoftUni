var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (true)
{
    var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "End")
    {
        break;
    }
    if (command[0] == "Add")
    {
        list.Add(int.Parse(command[1]));
    }
    else if (command[0] == "Insert")
    {
        if (int.Parse(command[2]) < 0 || int.Parse(command[2]) > list.Count - 1)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }
    else if (command[0] == "Remove")
    {
        if (int.Parse(command[1]) < 0 || int.Parse(command[1]) > list.Count - 1)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        list.RemoveAt(int.Parse(command[1]));
    }
    else if (command[0] == "Shift")
    {
       int times = int.Parse(command[2]);
        if (command[1] == "left")
        {
            for (int i = 0; i < times; i++)
            {
                int temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }
        }
        else
        {
            for (int i = 0; i < times; i++)
            {
                int temp = list[list.Count-1];
                list.RemoveAt(list.Count - 1);
                list.Insert(0,temp);
            }
        }
    }
    
}
Console.WriteLine(String.Join(" ", list));