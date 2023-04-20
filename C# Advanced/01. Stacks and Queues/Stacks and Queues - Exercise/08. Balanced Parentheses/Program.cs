var input = Console.ReadLine();
Stack<char> openeningBrackets = new();
bool balanced = true;
foreach (var item in input)
{
    if(item == '(' || item == '[' || item == '{')
    {
        openeningBrackets.Push(item);
    }
    else
    {
        if (openeningBrackets.Count > 0)
        {
            if (openeningBrackets.Peek() == '(' && item == ')')
            {
                openeningBrackets.Pop();
            }
            else if (openeningBrackets.Peek() == '[' && item == ']')
            {
                openeningBrackets.Pop();
            }
            else if (openeningBrackets.Peek() == '{' && item == '}')
            {
                openeningBrackets.Pop();
            }
            else
            {
                balanced = false;
                break;
            }
        }
        else //if the first char is closing bracket
        {
            balanced = false;
            break;
        }
    }
}
if (balanced && openeningBrackets.Count == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}