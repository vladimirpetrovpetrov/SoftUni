int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int result = DivideThirdFromSum(SumFirstTwo(a,b), c);
Console.WriteLine(result);





static int SumFirstTwo(int a , int b)
{
    return a + b;
}
static int DivideThirdFromSum(int a, int b)
{
    return a - b;
}