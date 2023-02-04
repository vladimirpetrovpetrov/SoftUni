var x = int.Parse(Console.ReadLine());
var op = Console.ReadLine();
var y = int.Parse(Console.ReadLine());
Console.WriteLine(MathOperate(x,y,op));




static int MathOperate(int x, int y,string op)
{
    if (op == "+")
    {
        return x + y;
    }else if (op == "-")
    {
        return x - y;
    }
    else if (op == "*")
    {
        return x * y;
    }
    else
    {
        return x / y;
    }
}