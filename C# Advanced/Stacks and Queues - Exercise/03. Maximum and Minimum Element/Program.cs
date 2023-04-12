int n = int.Parse(Console.ReadLine());
Stack<int> stack = new Stack<int>();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    if (input[0] == 1)
    {
        stack.Push(input[1]);
    }else if (input[0] == 2)
    {
        if(stack.Count == 0)
        {
            continue;
        }
        stack.Pop();
    }else if (input[0] == 3)
    {
        if (stack.Count == 0)
        {
            continue;
        }
        Console.WriteLine(stack.Max());
    }
    else if (input[0] == 4)
    {
        if (stack.Count == 0)
        {
            continue;
        }
        Console.WriteLine(stack.Min());
    }
}
Console.WriteLine(String.Join(", ",stack));