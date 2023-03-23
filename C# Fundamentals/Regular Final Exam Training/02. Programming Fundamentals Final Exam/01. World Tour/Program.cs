using System;

var input = Console.ReadLine();
while (true)
{
    var command = Console.ReadLine().Split(new char[] { ' ',':'},StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "Travel")
    {
        break;
    }
    if (command[0] == "Add")
    {
        var stopName = command[3];
        var index = int.Parse(command[2]);
        if(index < 0 || index > input.Length) 
        {
            Console.WriteLine(input);
            continue;
        }
        input = input.Insert(index, stopName);
        Console.WriteLine(input);
    }else if (command[0] == "Remove")
    {
        var startingIndex = int.Parse(command[2]);
        var endingIndex = int.Parse(command[3]);
        if (startingIndex < 0 || endingIndex > input.Length-1) 
        {
            Console.WriteLine(input);
            continue;
        }
        input = input.Remove(startingIndex,(endingIndex-startingIndex)+1);
        Console.WriteLine(input);
    }
    else if (command[0] == "Switch")
    {
        var oldString = command[1];
        var newString = command[2];
        input = input.Replace(oldString, newString);
        Console.WriteLine(input);
    }
}
Console.WriteLine($"Ready for world tour! Planned stops: {input}");