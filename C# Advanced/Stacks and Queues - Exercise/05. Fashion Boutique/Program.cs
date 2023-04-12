var values = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
var maxSum = int.Parse(Console.ReadLine());
Stack<int> box = new Stack<int>(values);
var racks = 1;
var sum = 0;
while(box.Count != 0)
{
    if (sum + box.Peek() <= maxSum)
    {
        sum += box.Pop();
    }
    else
    {
        racks++;
        sum = 0;
        sum += box.Pop();
    }
}
Console.WriteLine(racks);