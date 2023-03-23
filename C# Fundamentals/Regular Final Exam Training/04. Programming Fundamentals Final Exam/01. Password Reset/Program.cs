var input = Console.ReadLine();
while (true)
{
    var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "Done")
    {
        break;
    }
    if (command[0] == "TakeOdd")
    {
       var newString = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 != 0)
            {
                newString += input[i];
            }
        }
        input = newString;
        Console.WriteLine(input);
    }
    else if (command[0] == "Cut")
    {
        var index = int.Parse(command[1]);
        var length = int.Parse(command[2]);
        input = input.Remove(index, length);
        Console.WriteLine(input);
    }
    else if (command[0] == "Substitute")
    {
        var substring = command[1];
        var substitute = command[2];
        if (!input.Contains(substring))
        {
            Console.WriteLine("Nothing to replace!");
            continue;
        }
        input = input.Replace(substring,substitute);
        Console.WriteLine(input);
    }
}
Console.WriteLine($"Your password is: {input}");