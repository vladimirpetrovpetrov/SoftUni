using System.Runtime.CompilerServices;
using System.Xml.Serialization;

var n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    PrintTopNumber(i);
}
static void PrintTopNumber(int num)
{
    bool a = DivisibleByEight(num);
    bool b = HoldAtleastOneDigit(num);
    if (a && b)
    {
        Console.WriteLine(num);
    }
}
static bool HoldAtleastOneDigit(int n)
{
    bool oddDigit = false;
    while(n > 0)
    {
        int lastDigit = n % 10;
        if(lastDigit%2!=0)
        {
            oddDigit = true;
            break;
        }
        n /= 10;
    }
    return oddDigit;
}
static bool DivisibleByEight(int n)
{
    int digitsSum = DigitsSum(n);
    if (digitsSum % 8 == 0)
    {
        return true;
    }
    else { return false; }
}
static int DigitsSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}
