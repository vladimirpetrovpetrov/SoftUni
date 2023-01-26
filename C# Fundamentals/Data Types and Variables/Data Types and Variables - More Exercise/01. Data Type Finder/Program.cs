var input = "";

while (input != "END")
{

    input = Console.ReadLine();
    if(input == "END")
    {
        return;
    }
                

    if (Int32.TryParse(input, out _))
    {
        Console.WriteLine($"{input} is integer type");
    }
    else if (double.TryParse(input, out _))
    {
        Console.WriteLine($"{input} is floating point type");
    } 
    else if (bool.TryParse(input, out _))
    {
        Console.WriteLine($"{input} is boolean type");
    }
    else if (char.TryParse(input, out _))
    {
        Console.WriteLine($"{input} is character type");
    }
    else 
    {
        Console.WriteLine($"{input} is string type");

    }
}