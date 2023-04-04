var message = Console.ReadLine();

while (true)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "End")
    {
        break;
    }

    if (input[0] == "Translate")
    {
        var subchar = input[1];
        var replace = input[2];
        message = message.Replace(subchar, replace);
        Console.WriteLine(message);
    }else if (input[0] == "Includes")
    {
        var substring = input[1];
        var exist = message.Contains(substring);
        string result = exist ? "True" : "False";
        Console.WriteLine(result);

    }
    else if (input[0] == "Start")
    {
        var substring = input[1];
        var exist = message.StartsWith(substring);
        string result = exist ? "True" : "False";
        Console.WriteLine(result);
    }
    else if (input[0] == "Lowercase")
    {
        message = message.ToLower();
        Console.WriteLine(message);
    }
    else if (input[0] == "FindIndex")
    {
        var subchar = input[1];
        var index = message.LastIndexOf(subchar);
        Console.WriteLine(index);
    }
    else if (input[0] == "Remove")
    {
        var startingIndex = int.Parse(input[1]);
        var count = int.Parse(input[2]);
        message = message.Remove(startingIndex, count);
        Console.WriteLine(message);
    }
}