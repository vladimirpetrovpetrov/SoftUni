var input = Console.ReadLine();

while (true)
{
    var command = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "Decode")
    {
        break;
    }
    if (command[0] == "ChangeAll")
    {
        var substring = command[1];
        var replacement = command[2];
        input = ChangeAll(input,substring, replacement);
    }else if (command[0] == "Insert")
    {
        var index = int.Parse(command[1]);
        var value = command[2];
        input = Insert(input, index, value);
    }else if (command[0] == "Move")
    {
        var count = int.Parse(command[1]);
        input = Move(input, count);
    }
}
Console.WriteLine($"The decrypted message is: {input}");
static string ChangeAll(string input, string substring,string replacement)
{
    return input.Replace(substring, replacement);
}
static string Insert(string input, int index, string value)
{
    return input.Insert(index, value);
}
static string Move(string input, int count)
{
    string temp = input.Substring(0, count);
    string temp2 = input.Substring(count);
    return new string(temp2.Concat(temp).ToArray());
}