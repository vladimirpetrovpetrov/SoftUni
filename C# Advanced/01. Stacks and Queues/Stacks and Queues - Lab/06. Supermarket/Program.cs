Queue<string> queue = new Queue<string>();
while (true)
{
    var input = Console.ReadLine();
    if(input == "End")
    {
        break;
    }

    if (input == "Paid")
    {
        Console.WriteLine(String.Join(Environment.NewLine,queue));
        queue.Clear();
    }
    else
    {
        queue.Enqueue(input!);
    }
}
Console.WriteLine($"{queue.Count} people remaining.");