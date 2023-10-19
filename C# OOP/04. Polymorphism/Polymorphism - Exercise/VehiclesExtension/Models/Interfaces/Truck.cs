namespace VehiclesExtension.Models.Interfaces;

public class Truck : Vehicle
{
    private const double FuelConsumptionIncrement = 1.6;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, FuelConsumptionIncrement)
    {
    }

    public override void Refuel(double liters)
    {
        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
        }
        else
        {
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else
            {
                this.FuelQuantity += (liters * 0.9);
            }
        }
    }
}
