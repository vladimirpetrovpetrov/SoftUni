var num = int.Parse(Console.ReadLine());
List<string> list = new List<string>();
for (int i = 0; i < num; i++)
{
    list.Add(Console.ReadLine());
}
list.Sort();
for (int i = 1; i <= num; i++)
{
    Console.WriteLine($"{i}.{list[i-1]}");
}