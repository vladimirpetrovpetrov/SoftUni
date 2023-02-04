var x = int.Parse(Console.ReadLine());
var y = int.Parse(Console.ReadLine());
var z = int.Parse(Console.ReadLine());
Console.WriteLine(SmallestOfThree(x,y,z));





static int SmallestOfThree(int a,int b,int c)
{
    if (a <= b)
    {
        return a <= c ? a : c;
    }
    else
    {
        return b <= c ? b : c;
    }
}