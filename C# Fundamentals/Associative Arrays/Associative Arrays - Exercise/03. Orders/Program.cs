namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Product>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "buy")
                {
                    break;
                }
                var productName = input[0];
                var productPrice = decimal.Parse(input[1]);
                var productQuantity = int.Parse(input[2]);

                if (!dict.ContainsKey(productName))
                {
                    dict.Add(productName, new Product(productPrice, productQuantity));
                }
                else
                {
                    dict[productName].ChangePriceAndQuantity(productPrice, productQuantity);
                }
            }
            foreach (var (key,value) in dict)
            {
                Console.WriteLine(key + value);
            }
        }
    }
    public class Product
    {
        public void ChangePriceAndQuantity(decimal newPrice,int extraQuantity)
        {
            this.Price = newPrice;
            this.Quantity += extraQuantity;
        }

        public Product( decimal price, int quantity)
        {
            
            Price = price;
            Quantity = quantity;
        }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $" -> {this.Price * this.Quantity:f2}";
        }
    }
}