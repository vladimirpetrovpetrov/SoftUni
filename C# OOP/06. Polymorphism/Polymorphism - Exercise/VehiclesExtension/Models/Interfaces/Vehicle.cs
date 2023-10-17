namespace VehiclesExtension.Models.Interfaces;

public abstract class Vehicle : IVehicle
{
    protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;
        if (fuelQuantity > tankCapacity)
        {
            this.TankCapacity = 0;
        }
    }
    public double FuelQuantity { get; private set; }

    public virtual double FuelConsumption { get; private set; }
    public double TankCapacity { get; private set; }
    public bool IsEmpty { get; private set; }

    public void Drive(double distance, bool isEmpty = true)
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
            this.FuelQuantity += liters;
        }


    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}
