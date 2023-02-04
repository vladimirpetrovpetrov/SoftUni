using System.Diagnostics.CodeAnalysis;

var x = decimal.Parse(Console.ReadLine());
var y = decimal.Parse(Console.ReadLine());
decimal result = Factoriel(x) / Factoriel(y);
Console.WriteLine($"{result:f2}");

static decimal Factoriel(decimal x)
{
    
    if (x == 1)
    {
        return 1;
    }
   return x * Factoriel(x - 1);
}