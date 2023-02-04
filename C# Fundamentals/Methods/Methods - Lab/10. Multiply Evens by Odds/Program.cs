var x = int.Parse(Console.ReadLine());
Console.WriteLine(GetMultipleOfEvenAndOdds(FindEvenSum(x),FindOddSum(x)));



static int GetMultipleOfEvenAndOdds(int x , int y)
{
    return x * y;
}
static int FindEvenSum(int x)
{
    int result = Math.Abs(x);
    int sum = 0;
    while (result > 0)
    {
        int lastDigit = result % 10;
        if ( lastDigit % 2 == 0)
        {
            sum += lastDigit;
        }
        result /= 10;
    }
    return sum;
}
static int FindOddSum(int x)
{
    int result = Math.Abs(x);
    int sum = 0;
    while (result > 0)
    {
        int lastDigit = result % 10;
        if (lastDigit % 2 != 0)
        {
            sum += lastDigit;
        }
        result /= 10;
    }
    return sum;
}