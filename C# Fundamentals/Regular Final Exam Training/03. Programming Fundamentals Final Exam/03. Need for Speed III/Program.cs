int n = int.Parse(Console.ReadLine());
var cars = new Dictionary<string, List<int>>();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
    var car = input[0];
    var mileage = int.Parse(input[1]);
    var fuel = int.Parse(input[2]);
    cars[car] = new List<int> {mileage, fuel};
}
while (true)
{
    var input = Console.ReadLine().Split(" : ", StringSplitOptions.RemoveEmptyEntries);
    if (input[0] == "Stop")
    {
        break; 
    }
    if (input[0] == "Drive")
    {

        var car = input[1];
        var distance = int.Parse(input[2]);
        var fuel = int.Parse(input[3]);
        if (fuel > cars[car][1])
        {
            Console.WriteLine("Not enough fuel to make that ride");
            continue;
        }
        cars[car][0] += distance;
        cars[car][1] -= fuel;
        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        if (cars[car][0] >= 100000)
        {
            cars.Remove(car);
            Console.WriteLine($"Time to sell the {car}!");
        }
    }
    else if (input[0] == "Refuel")
    {
        var car = input[1];
        var fuel = int.Parse(input[2]);
        cars[car][1] += fuel;
        if (cars[car][1] > 75)
        {
            var leftover = cars[car][1] - 75;
            cars[car][1] = 75;
            fuel-=leftover;
        }
        Console.WriteLine($"{car} refueled with {fuel} liters");

    }else if (input[0] == "Revert")
    {
        var car = input[1];
        var km = int.Parse(input[2]);
        cars[car][0] -= km;
        if (cars[car][0] < 10000)
        {
            cars[car][0] = 10000;
            continue;
        }
        Console.WriteLine($"{car} mileage decreased by {km} kilometers");
    }
}
foreach (var (key,value) in cars)
{
    Console.WriteLine($"{key} -> Mileage: {value[0]} kms, Fuel in the tank: {value[1]} lt.");
}

