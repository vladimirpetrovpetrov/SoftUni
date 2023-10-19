namespace Cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICollection<Card> cards = new List<Card>(); 
            var input = Console.ReadLine();
            var deck = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in deck)
            {
                var face = item.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                var suit = item.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                try
                {
                    cards.Add(new Card(face, suit));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(String.Join(" ", cards));




        }
    }

}