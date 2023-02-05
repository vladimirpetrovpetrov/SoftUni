//Try to do this WITHOUT multiplying the 3 numbers.

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

bool zero = IsItZero(num1) || IsItZero(num2) || IsItZero(num3);
if (zero)
{
    Console.WriteLine("zero");
    return;
}
else
{
   IsItNegative(num1,num2,num3); 
}
static bool IsItZero (int num)
{
    if (num == 0)
    {
        return true;
    }
    else 
    { 
        return false;
    }
}
static void IsItNegative(int num,int num2,int num3)
{
    bool a = num < 0;
    bool b = num2 < 0;
    bool c = num3 < 0;
    bool[] bools = new bool[3] { a, b, c };
    int negative = 0;
    for (int i = 0; i < bools.Length; i++)
    {
        if (bools[i])
        {
            negative++;
        }
    }
    if(negative == 0)
    {
        Console.WriteLine("positive");
    }else if(negative == 1 || negative == 3)
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("positive");
    }


}