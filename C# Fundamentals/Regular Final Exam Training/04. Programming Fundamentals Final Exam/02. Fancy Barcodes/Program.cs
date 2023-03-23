using System.Text.RegularExpressions;

int n = int.Parse(Console.ReadLine());
Regex regex = new Regex(@"(\@\#+)(?<seq>[A-Z][A-Za-z0-9]{4,}[A-Z])\@\#+");
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine();
    Match match = regex.Match(input);
    if (!match.Success)
    {
        Console.WriteLine("Invalid barcode");
        continue;
    }
    var group = string.Empty;
    foreach (var item in match.Value)
    {
        if (Char.IsDigit(item))
        {
            group += (char)item;
        }
    }
    if(group == string.Empty)
    {
        group = "00";
    }
    Console.WriteLine($"Product group: {group}");
}