var x = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

for (int i = 0; i < x.Count - 1; i++)
{
    
    if (x[i] == x[i + 1])
    {
        x[i] *= 2;
        x.RemoveAt(i+1);
        i = -1;
    }
}
Console.WriteLine(String.Join(" ",x));

