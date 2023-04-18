var operationCount = int.Parse(Console.ReadLine());
Stack<char> stack = new Stack<char>();
List<string> stackArchive = new();
stack.Push(' ');
stackArchive.Add(stack.Peek().ToString());
for (int i = 0; i < operationCount; i++)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "1")
    {
        var toAdd = input[1];
        foreach (var item in toAdd)
        {
            stack.Push(item);
        }
        stackArchive.Add(String.Join("", stack.Reverse()));
    }
    else if (input[0] == "2")
    {
        var lastCount = int.Parse(input[1]);
        for (int j = 0; j < lastCount; j++)
        {
            stack.Pop();
        }
        stackArchive.Add(String.Join("", stack.Reverse()));
    }
    else if (input[0] == "3")
    {
        var index = int.Parse(input[1]);
        var text = new string(string.Join("", stack).Reverse().ToArray());
        Console.WriteLine(text[index]);
    }
    else if (input[0] == "4")
    {
        Stack<char> temp = new Stack<char>(stackArchive[stackArchive.Count - 2]);
        stack = temp;
        stackArchive.RemoveAt(stackArchive.Count - 1);
    }
}