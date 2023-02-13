var list1 = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var list2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int min = 0;
int max = 0;
list2.Reverse();
if (list1.Count > list2.Count)
{
    min = Math.Min(list1[list1.Count - 1], list1[list1.Count - 2]);
    max = Math.Max(list1[list1.Count - 1], list1[list1.Count - 2]);
    list1.RemoveAt(list1.Count- 1);
    list1.RemoveAt(list1.Count - 1);
}
else
{
    min = Math.Min(list2[list2.Count - 1], list2[list2.Count - 2]);
    max = Math.Max(list2[list2.Count - 1], list2[list2.Count - 2]);
    list2.RemoveAt(list2.Count- 1);
    list2.RemoveAt(list2.Count - 1);
}


List<int> concList = new List<int>();
for (int i = 0; i < Math.Min(list1.Count,list2.Count); i++)
{
    concList.Add(list1[i]);
    concList.Add(list2[i]);
}
concList.RemoveAll(x => x <= min || x >= max);
Console.WriteLine(String.Join(" ", concList.OrderBy(x => x)));