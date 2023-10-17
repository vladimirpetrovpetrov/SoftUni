namespace Vehicles.Models.Interfaces;

public abstract class Vehicle : IVehicle
{
    protected Vehicle(double fuelQuantity, double fuelConsumption, double fuelConsumptionIncrement)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption + fuelConsumptionIncrement;
    }
    public double FuelQuantity { get; private set; }

    public double FuelConsumption { get; private set; }

    public void Drive(double distance)
    {
        double requiredFuel = distance * this.FuelConsumption;
        if(requiredFuel > this.FuelQuantity)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else
        {
            this.FuelQuantity -= requiredFuel;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }

    public virtual void Refuel(double liters)
    {
        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
