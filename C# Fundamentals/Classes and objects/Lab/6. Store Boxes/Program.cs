public class Program
{
    static void Main()
    {
        var boxes = new List<Box>();
        while (true)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            if (input[0] == "end")
            {
                break;
            }
            boxes.Add(new Box
            {
                SerialNumber = input[0],
                Item = new Item
                {
                    Name = input[1],
                    Price = double.Parse(input[3])
                },
                ItemQuantity = int.Parse(input[2])
            });
        }
        boxes.OrderByDescending(x => x.Price).ToList().ForEach(x => Console.WriteLine($"{x.SerialNumber}" +
        Environment.NewLine + $"-- { x.Item.Name} - ${ x.Item.Price:f2}: { x.ItemQuantity}" +
        Environment.NewLine + $"-- ${ x.Price:f2}"));
    }
}
public class Item
{
    public string Name { get; set; } //2
    public double Price { get; set; } //4

}
public class Box
{
    public string SerialNumber { get; set; } // 1
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }//3
    public double Price
    {
        get { return Item.Price * ItemQuantity; }
        set { Price = Item.Price * ItemQuantity; }
    }


}