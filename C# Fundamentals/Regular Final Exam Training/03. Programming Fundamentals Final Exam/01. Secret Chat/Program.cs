var input = Console.ReadLine();
while (true)
{
    var command = Console.ReadLine().Split(":|:", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "Reveal")
    {
        break;
    }
    if (command[0] == "InsertSpace")
    {
        input = input.Insert(int.Parse(command[1]), " ");
        Console.WriteLine(input);
    }
    else if (command[0] == "Reverse")
    {
        var substring = command[1];
        if (!input.Contains(substring))
        {
            Console.WriteLine("error");
            continue;
        }
        var reversed = new string(substring.Reverse().ToArray());
        var index = input.IndexOf(substring);
        input = input.Remove(index,substring.Length);
        input = input+ reversed;
        
        Console.WriteLine(input);
    }
    else if (command[0] == "ChangeAll")
    {
        var substring = command[1];
        var replacement = command[2];
        input = input.Replace(substring, replacement);
        Console.WriteLine(input);
    }
}
Console.WriteLine($"You have a new text message: {input}");