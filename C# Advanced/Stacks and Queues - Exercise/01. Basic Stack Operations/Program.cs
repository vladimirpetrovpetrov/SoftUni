var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var toAdd = input[0];
var toRemove = input[1];
var toCheck = input[2];
Stack<int> stack = new Stack<int>();
var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
for (int i = 0; i < toAdd; i++)
{
    stack.Push(numbers[i]);
}
for (int i = 0;i< toRemove; i++)
{
    stack.Pop();
}
bool isTrue = stack.Contains(toCheck);
if (stack.Count() > 0) {
    if (isTrue)
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