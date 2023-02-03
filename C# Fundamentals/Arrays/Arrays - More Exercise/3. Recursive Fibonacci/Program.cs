var n = int.Parse(Console.ReadLine());

Console.WriteLine(GetFibonacci(n));



int GetFibonacci(int n)
{
    if (n <= 2)
    {
        return 1;
    }

   return GetFibonacci(n - 1) + GetFibonacci(n - 2);
}
