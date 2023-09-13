namespace CustomList;

internal class Program
{
    static void Main(string[] args)
    {
        CustomList list = new CustomList();

        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);  
        list.Add(5);
        list.Add(6);
        list.Add(7);
        list.Add(8);

        list.InsertAt(2, 111);

        Console.WriteLine(list.Contains(112));
        Console.WriteLine($"{list[0]} {list[2]}");
        list.Swap(0, 2);
        Console.WriteLine($"{list[0]} {list[2]}");
        list.AddRange(new int[] { 1, 2, 3 });
        list.ForEach(x => Console.WriteLine(x));
        
     }
}