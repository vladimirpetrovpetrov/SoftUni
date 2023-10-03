using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension;

public class Bus : Vehicle
{
    private const double additionalFuelConsumption = 1.4;
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption + additionalFuelConsumption, tankCapacity) { }

    public void DriveEmpty(double distance)
    {
        FuelQuantity -= distance * (FuelConsumption - additionalFuelConsumption);

        if (FuelQuantity <= 0)
        {
            FuelQuantity += distance * (FuelConsumption - additionalFuelConsumption);
            Console.WriteLine("Bus needs refueling");
        }

        else
        {
            Console.WriteLine($"Bus travelled {distance} km");
        }
    }

}
