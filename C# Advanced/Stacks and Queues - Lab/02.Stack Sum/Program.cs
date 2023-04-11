var input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var stack = new Stack<int>(input);

while (true)
{
    var command = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "end")
    {
        break;
    }
    if (command[0] == "add")
    {
        var numOne = int.Parse(command[1]);
        var numTwo = int.Parse(command[2]);
        stack.Push(numOne);
        stack.Push(numTwo);
    }else if (command[0] == "remove")
    {
        var nToRemove = int.Parse(command[1]);
        if(stack.Count >= nToRemove)
        {
            for (int i = 0; i < nToRemove; i++)
            {
                stack.Pop();
            }
        }
    }
}
Console.WriteLine($"Sum: {stack.Sum()}");