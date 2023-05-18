
namespace Basic_Inventory_Management_Sytem
{
    public class Item
    {
        public Item(string Name,int Quantity, decimal Price)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.Price = Price;
        }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        
    }
}
