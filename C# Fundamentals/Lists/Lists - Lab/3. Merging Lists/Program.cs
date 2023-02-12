List<double> list = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
List<double> list2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList(); int index = 0;
List<double> list3 = new List<double>();

for (int i = 0;i< Math.Max(list.Count,list2.Count); i++)
{
    if (i <= list.Count - 1)
    {
        list3.Add(list[i]);
    }
    if (i <= list2.Count - 1)
    {
        list3.Add(list2[i]);
    }
}
Console.WriteLine(String.Join(" ",list3));