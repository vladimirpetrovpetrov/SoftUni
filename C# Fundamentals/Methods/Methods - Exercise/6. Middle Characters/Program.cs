var input = Console.ReadLine();
Console.WriteLine(FindMiddleChars(input));

static string FindMiddleChars(string input)
{
    if(input.Length % 2 != 0)
    {
        return input[input.Length/2].ToString();
    }
    else
    {
        string result = string.Empty;
        result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
        return result; 
    }
}