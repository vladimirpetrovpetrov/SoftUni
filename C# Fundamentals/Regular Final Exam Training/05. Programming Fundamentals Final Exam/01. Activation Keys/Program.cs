using System.Data.SqlTypes;
using System;

var rawKey = Console.ReadLine();
while (true)
{
    var input = Console.ReadLine().Split(">>>", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "Generate")
    {
        break;
    }
    if (input[0] == "Contains") 
    {
        var substring = input[1];
        bool subExist = rawKey.Contains(substring);
        if(!subExist)
        {
            Console.WriteLine($"Substring not found!");
            continue;
        }
        Console.WriteLine($"{rawKey} contains {substring}");


    }else if (input[0] == "Flip")
    {
        var isUpper = input[1] == "Upper";
        
            int startIndex = int.Parse(input[2]);
            int endIndex = int.Parse(input[3]);
            var substring = rawKey.Substring(startIndex, endIndex - startIndex);
            var partOne = rawKey.Substring(0,startIndex);
            var partTwo = rawKey.Substring(endIndex,rawKey.Length-endIndex);
        if (isUpper)
        {
            rawKey = String.Concat(partOne, substring.ToUpper(), partTwo);
            Console.WriteLine(rawKey);
        }
        else
        {
            rawKey = String.Concat(partOne, substring.ToLower(), partTwo);
            Console.WriteLine(rawKey);
        }
    }
    else if (input[0] == "Slice")
    {
        int startIndex = int.Parse(input[1]);
        int endIndex = int.Parse(input[2]);

        rawKey = rawKey.Remove(startIndex,endIndex-startIndex);
        Console.WriteLine(rawKey);
    }
}
Console.WriteLine($"Your activation key is: {rawKey}");