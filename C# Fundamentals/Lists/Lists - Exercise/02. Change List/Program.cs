var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

while (true)
{
    var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "end")
    {
        break;
    }
    if (command[0] == "Delete")
    {
        list.RemoveAll(x => x == int.Parse(command[1]));
    }else if (command[0] == "Insert")
    {
        list.Insert(int.Parse(command[2]), int.Parse(command[1]));
    }
}
Console.WriteLine(String.Join(" ", list));