var list = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();


while (true)
{
    var line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (line[0] == "end")
    {
        break;
    }
    if (line[0] == "Add")
    {
        int num = int.Parse(line[1]);   
        list.Add(num);
    }
    else if (line[0] == "Remove")
    {
        int num = int.Parse(line[1]);
        list.Remove(num);
    }else if (line[0] == "RemoveAt")
    {
        int num = int.Parse(line[1]);
        list.RemoveAt(num);
    }
    else if (line[0] == "Insert")
    {
        int index = int.Parse(line[2]);
        int num = int.Parse(line[1]);
        list.Insert(index,num);
    }
}
Console.WriteLine(String.Join(" ",list));

