namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var command = input[0];
                var username = input[1];
                

                if (command == "register")
                {
                    var licensePlate = input[2];
                    if (!dict.ContainsKey(username))
                    {
                        dict.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dict[username]}");
                    }
                }
                else if (command == "unregister")
                {
                    if(!dict.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        dict.Remove(username);
                    }
                }
            }
            foreach (var (key,value) in dict)
            {
                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}