namespace _4._First_and_Reserve_Team
{
    internal class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Team team = new Team("SoftUni");

            for (int i = 0; i < n; i++)
            {
                var inputInfo = Console.ReadLine().Split();

                int age = int.Parse(inputInfo[2]);
                decimal salary = decimal.Parse(inputInfo[3]);

                Person person = new Person(inputInfo[0], inputInfo[1], age, salary);
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"First team has {team.ReserveTeam.Count} players.");

        }
    }
}