using System.Text;

var input = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> dict = new();
foreach (var item in input)
{
    if (!dict.ContainsKey(item))
    {
        dict[item] = 1;
    }
    else
    {
        dict[item]++;
    }

}
StringBuilder st = new StringBuilder();
foreach (var (k,v) in dict)
{
    st.AppendLine($"{k} - {v} times");
}
Console.WriteLine(st.ToString().TrimEnd());