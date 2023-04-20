var itemValues = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
Stack<int> stack = new Stack<int>(itemValues);
var capOfOneRack = int.Parse(Console.ReadLine());
var racks = 1;
var currentValue = 0;

while (stack.Count > 0)
{
    if (currentValue + stack.Peek() < capOfOneRack)
    {
        currentValue += stack.Pop();
    }
    else if (currentValue + stack.Peek() == capOfOneRack)
    {
        if (stack.Count > 1)
        {
            stack.Pop();
            currentValue = 0;
            racks++;
        }
        else
        {
            stack.Pop();
        }
    }
    else
    {
        currentValue = 0;
        racks++;
        currentValue += stack.Pop();
    }
}
Console.WriteLine(racks);
