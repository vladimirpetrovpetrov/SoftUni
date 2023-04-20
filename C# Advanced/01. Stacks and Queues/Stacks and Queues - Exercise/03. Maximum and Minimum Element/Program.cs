Stack<int> stack = new Stack<int>();
var n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

    var op = int.Parse(input[0]);
    if(op == 1)
    {
        var toPush = int.Parse(input[1]);
        stack.Push(toPush);
    }else if (op == 2)
    {
        if (stack.Count > 0)
        {
            stack.Pop();
        }
        else
        {
            continue;
        }
    }else if (op == 3)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Max());
        }
    }else if(op == 4)
    {
        if (stack.Count > 0)
        {
            Console.WriteLine(stack.Min());
        }
    }
}
if(stack.Count > 0)
{
    Console.WriteLine(String.Join(", ",stack));
}