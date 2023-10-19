namespace FoodShortage
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);
            List<IBuyer> list = new List<IBuyer>(); 

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                IBuyer buyer;
                if(input.Length == 4)
                {
                    buyer = new Citizen(input[0]);
                }
                else
                {
                    buyer = new Rebel(input[0]);
                }
                list.Add(buyer);
            }
            var totalFood = 0;
            while (true)
            {
                var input = Console.ReadLine();
                if(input == "End")
                {
                    break;
                }
                IBuyer buyer = list.Find(x=>x.Name == input);
                if (buyer != null)
                {
                    totalFood += buyer.BuyFood();
                }
            }
            Console.WriteLine(totalFood);
        }
    }
}