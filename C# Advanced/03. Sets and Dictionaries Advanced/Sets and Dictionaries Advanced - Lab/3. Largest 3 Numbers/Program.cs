var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).OrderByDescending(x => x).ToArray();
if (input.Length < 3)
{
    Console.WriteLine(String.Join(" ", input));
}
else
{
    Array.Resize(ref input, 3);
    Console.WriteLine(String.Join(" ", input));
}

