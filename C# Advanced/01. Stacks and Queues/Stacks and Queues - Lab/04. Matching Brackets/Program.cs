var input = Console.ReadLine();
Stack<int> openingBracketsIndeces = new Stack<int>();
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        openingBracketsIndeces.Push(i);
    }else if (input[i] == ')')
    {
        var startingIndex = openingBracketsIndeces.Pop();
        var endingIndex = i;
        var substring = input.Substring(startingIndex, endingIndex - startingIndex + 1);
        Console.WriteLine(substring);
    }
}