var n = int.Parse(Console.ReadLine());
int sum = 0;
int lastDigit = 0;
int oldN = n;
while(n > 0)
{
    lastDigit = n % 10;
    sum += Factoriel(lastDigit);
    n /= 10;
}
if (sum == oldN)
{
    Console.WriteLine("yes");
}else { Console.WriteLine("no"); }
int Factoriel (int n)
{
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum *= i;
    }
    return sum;
}
