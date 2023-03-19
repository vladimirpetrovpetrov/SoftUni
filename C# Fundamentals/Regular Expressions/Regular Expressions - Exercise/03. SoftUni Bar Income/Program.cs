using System.Text.RegularExpressions;

string pattern = @"\%(?<customer>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";
var totalSum = 0m;


while (true)
{
    var input = Console.ReadLine();
    if (input == "end of shift")
    {
        break;
    }
    Regex regex = new Regex(pattern);
    if (regex.IsMatch(input))
    {
        var match = regex.Match(input);
        var name = match.Groups["customer"].Value;
        var product = match.Groups["product"].Value;
        var count = int.Parse(match.Groups["count"].Value);
        var price = decimal.Parse(match.Groups["price"].Value);
        var totalForProduct = count * price;
        totalSum += totalForProduct;
        Console.WriteLine($"{name}: {product} - {totalForProduct:F2}");
    }
}
Console.WriteLine($"Total income: {totalSum:F2}");