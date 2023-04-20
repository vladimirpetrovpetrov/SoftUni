var input = Console.ReadLine();
Stack<char> output = new Stack<char>();
foreach (var c in input)
{
    output.Push(c);
}
Console.WriteLine(String.Join("",output)); 