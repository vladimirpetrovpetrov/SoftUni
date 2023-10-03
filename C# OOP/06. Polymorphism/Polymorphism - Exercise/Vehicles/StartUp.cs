namespace Vehicles;

public class StartUp
{
    static void Main(string[] args)
    {
        var carInput = Console.ReadLine().Split();
        var truckInput = Console.ReadLine().Split();


        Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]));
        Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]));
        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            switch (input[0])
            {
                case "Drive":
                    var distance = double.Parse(input[2]);
                    switch (input[1])
                    {
                        case "Car":

                            car.Drive(distance);
                            break;
                        case "Truck":
                            truck.Drive(distance);
                            break;
                        default:
                            break;
                    }
                    break;
                case "Refuel":
                    var quantity = double.Parse(input[2]);
                    switch (input[1])
                    {
                        case "Car":
                            car.Refuel(quantity);
                            break;
                        case "Truck":
                            truck.Refuel(quantity);
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine($"Car: {car.FuelQuantity:F2}");
        Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
    }
}