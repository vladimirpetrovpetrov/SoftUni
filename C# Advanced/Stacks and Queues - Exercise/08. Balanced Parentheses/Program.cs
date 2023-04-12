var input = Console.ReadLine();
Stack<char> stack = new Stack<char>();
bool isValid = true;
foreach (var item in input)
{
    if (item == '(' || item == '{' || item == '[')
    {
        stack.Push(item);
    }
    else
    {
        if (item == ')')
        {
            if (stack.Count > 0)
            {
                if (stack.Peek() != '(')
                {
                    isValid = false;
                    break;
                }
                else
                {
                    stack.Pop();
                }
            }
        }
        else if (item == ']')
        {
            if (stack.Peek() != '[')
            {
                isValid = false;
                break;
            }
            else
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
        }
        else if (item == '}')
        {
            if (stack.Peek() != '{')
            {
                isValid = false;
                break;
            }
            else
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
        }
    }
}
if (isValid)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}