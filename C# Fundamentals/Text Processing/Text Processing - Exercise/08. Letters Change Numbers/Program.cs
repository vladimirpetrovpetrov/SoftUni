var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

var sum = 0d;
var alphabet = "abcdefghijklmnopqrstuvwxyz";

foreach (var item in input)
{
    char first = item[0];
    char last = item[^1];
    var firstPosition = alphabet.IndexOf(Char.ToLower(first)) + 1;
    var secondPosition = alphabet.IndexOf(Char.ToLower(last)) + 1;
    double number = double.Parse(item.Substring(1, item.Length - 2));

    bool isUpper = char.IsUpper(first);
    if (isUpper)
    {
        sum += number / firstPosition;
    }
    else
    {
        sum += number * firstPosition;
    }

    isUpper = char.IsUpper(last);
    if (isUpper)
    {
        sum -= secondPosition;
    }
    else
    {
        sum += secondPosition;
    }


}
Console.WriteLine($"{sum:F2}");