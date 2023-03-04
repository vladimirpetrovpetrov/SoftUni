namespace _02._Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            while (true)
            {
                var theKey = Console.ReadLine();
                if (theKey == "stop")
                {
                    break;
                }
                if (!dict.ContainsKey(theKey))
                {
                    dict.Add(theKey, 0);
                }
                var theValue = int.Parse(Console.ReadLine());
                dict[theKey] += theValue;

            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}