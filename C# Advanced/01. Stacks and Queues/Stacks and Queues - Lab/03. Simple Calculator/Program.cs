var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
input = input.Reverse().ToArray();
Stack<string> output = new Stack<string>(input);
int result = int.Parse(output.Pop());
while(output.Count != 0)
{
    string sign = output.Pop();
    if(sign == "+")
    {
        result += int.Parse(output.Pop());
    }
    else
    {
        result -= int.Parse(output.Pop());
    }
}
Console.WriteLine(result);