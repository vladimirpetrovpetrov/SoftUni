while (true)
{
    var input = Console.ReadLine();
    if(input == "end")
    {
        break;
    }
    string reversedString = new string(input.Reverse().ToArray());
    Console.WriteLine($"{input} = {reversedString}");
}