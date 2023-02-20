var route = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries).ToList();
var startingFuel = int.Parse(Console.ReadLine());
var startingAmmo = int.Parse(Console.ReadLine());

for (int i = 0; i < route.Count; i++)
{
    var splitted = route[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    string command = splitted[0];
    int number = 0;
    if (command != "Titan")
    {
        number = int.Parse(splitted[1]);
    }
    if (command == "Travel")
    {
        startingFuel -= number;
        if (startingFuel >= 0) 
        {
            Console.WriteLine($"The spaceship travelled {number} light-years.");
        }
        else
        {
            Console.WriteLine("Mission failed.");
            break;
        }
    }
    else if (command == "Enemy")
    {
        if (startingAmmo >= number)
        {
            startingAmmo -= number;
            Console.WriteLine($"An enemy with {number} armour is defeated.");
        }
        else
        {
            if (startingFuel >= 2 * number)
            {
                startingFuel -= number * 2;
                Console.WriteLine($"An enemy with {number} armour is outmaneuvered.");
            }
            else
            {
                Console.WriteLine("Mission failed.");
                return;
            }
        }
    }
    else if (command == "Repair")
    {
        startingFuel += number;
        startingAmmo += 2 * number;
        Console.WriteLine($"Ammunitions added: {number * 2}.");
        Console.WriteLine($"Fuel added: {number}.");
    }
    else if (command == "Titan")
    {
        Console.WriteLine("You have reached Titan, all passengers are safe.");
    }
}