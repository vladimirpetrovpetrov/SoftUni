public class Program
{
    static void Main()
    {
        var times = int.Parse(Console.ReadLine());
        List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
        List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        List<string> cities = new List<string>(){ "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
        Random random = new Random();
        for (int i = 0; i < times; i++)
        {
            int num1 = random.Next(0, phrases.Count);
            int num2 = random.Next(0, events.Count);
            int num3 = random.Next(0, authors.Count);
            int num4 = random.Next(0, cities.Count);

            Console.WriteLine($"{phrases[num1]} {events[num2]} {authors[num3]} – {phrases[num4]}.");
        }


    }
}