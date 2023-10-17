namespace VehiclesExtension.Models.Interfaces;

public class Truck : Vehicle
{
    private const double fuelConsumptionIncrement = 1.6;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }

    public override double FuelConsumption =>
        base.FuelConsumption + fuelConsumptionIncrement;
    public override void Refuel(double liters)
    {
        if (this.FuelQuantity + liters > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
        }
        else
        {
            if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            base.Refuel(liters);

        }
    }
}
