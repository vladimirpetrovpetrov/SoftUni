var lengths = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int n = lengths[0];
int m = lengths[1];
HashSet<int> setOne = new HashSet<int>();
HashSet<int> setTwo = new HashSet<int>();
for (int i = 0; i < n + m; i++)
{
    var input = int.Parse(Console.ReadLine());
    if (i < n)
    {
        setOne.Add(input);
    }
    else
    {
        setTwo.Add(input);
    }
}
setOne.IntersectWith(setTwo);
if (setOne.Count > 0)
{
    Console.WriteLine(String.Join(" ", setOne));
}