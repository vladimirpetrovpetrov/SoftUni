namespace VehiclesExtension.Models.Interfaces;

public abstract class Vehicle : IVehicle
{
    protected Vehicle(double fuelQuantity, double fuelConsumption,double tankCapacity ,double fuelConsumptionIncrement)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption + fuelConsumptionIncrement;
        this.TankCapacity = tankCapacity;
        if(this.FuelQuantity > this.TankCapacity)
        {
            this.FuelQuantity = 0;
        }
    }
    public double FuelQuantity { get; protected set; }

    public double FuelConsumption { get; private set; }
    public double TankCapacity { get; private set; }

    public virtual void Drive(double distance, bool IsEmpty)
    {
        double requiredFuel = distance * this.FuelConsumption;
        if (requiredFuel > this.FuelQuantity)
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
                this.FuelQuantity += liters;
            }
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
