var wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
var maxPass = int.Parse(Console.ReadLine());

while (true)
{
    var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "end")
    {
        break;
    }
    if (command[0] == "Add")
    {
        wagons.Add(int.Parse(command[1]));
    }
    else
    {
        int newPass = int.Parse(command[0]);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + newPass <= maxPass)
            {
                wagons[i] += newPass;
                break;
            }
        }
    }
}
Console.WriteLine(String.Join(" ",wagons));