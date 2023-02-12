var x = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

for (int i = 0; i < x.Count-1; i++)
{
    x[i] += x[x.Count - 1];
    x.RemoveAt(x.Count - 1);
}
Console.WriteLine(string.Join(" ",x));
