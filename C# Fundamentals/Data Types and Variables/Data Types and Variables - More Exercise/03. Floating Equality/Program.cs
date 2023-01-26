var n = decimal.Parse(Console.ReadLine());
var m = decimal.Parse(Console.ReadLine());

decimal result = Math.Abs(n-m);
if (result >= 0.000001m)
{
    Console.WriteLine("False");
}

else
{
    Console.WriteLine("True");
}