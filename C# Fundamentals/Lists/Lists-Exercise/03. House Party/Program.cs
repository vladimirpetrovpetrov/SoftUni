var num = int.Parse(Console.ReadLine());
List<string> list = new List<string>();
for (int i = 0; i < num; i++)
{
    var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (!list.Contains(command[0])&& command[2] != "not")
    {
        list.Add(command[0]);
    }else if (list.Contains(command[0]) && command[2] != "not")
    {
        Console.WriteLine($"{command[0]} is already in the list!");
    }else if (list.Contains(command[0]) && command[2] == "not")
    {
        list.Remove(command[0]);
    }else if (!list.Contains(command[0]) && command[2] == "not")
    {
        Console.WriteLine($"{command[0]} is not in the list!");
    }
}
Console.WriteLine(String.Join(Environment.NewLine,list));