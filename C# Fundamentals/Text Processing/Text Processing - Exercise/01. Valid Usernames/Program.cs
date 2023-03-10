using System;

var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
foreach (var item in input)
{
    if (IsNameValid(item))
    {
        Console.WriteLine(item);
    }
}

static bool IsNameValid(string item)
{
    var validLenght = item.Length >= 3 && item.Length <= 16;
    var validSyntax = item.All(x => Char.IsDigit(x) || Char.IsLetter(x) || x == '-' || x == '_');
    return validLenght && validSyntax;

}