var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); 
var toAdd = input[0];
var toPop = input[1];
var toCheck = input[2];
var nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(nums);
for (int i = 0; i < toPop; i++)
{
    if(stack.Count == 0)
    {
        Console.WriteLine(0);
        return;
    }
    stack.Pop();
}
if (stack.Count > 0)
{
    if (stack.Contains(toCheck))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine(stack.Min());
    }
}
else
{
    Console.WriteLine(0);
}