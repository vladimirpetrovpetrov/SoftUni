namespace ExplicitInterface
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                citizens.Add(new Citizen(tokens[0], int.Parse(tokens[2]), tokens[1]));
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine(((IPerson)citizen).GetName());
                Console.WriteLine(((IResident)citizen).GetName());
            }
        }
    }
}