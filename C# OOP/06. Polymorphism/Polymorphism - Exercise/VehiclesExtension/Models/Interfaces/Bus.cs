using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models.Interfaces;

public class Bus : Vehicle
{
    private const double FuelConsumptionIncrement = 1.4;
    private const double FuelConsumptionWhileEmpty = 0;
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, FuelConsumptionWhileEmpty)
    {
    }

    public override void Drive(double distance, bool IsEmpty)
    {
        if (IsEmpty) 
        { 
            base.Drive(distance, IsEmpty);
        }
        else
        {
            double requiredFuel = distance * (this.FuelConsumption + FuelConsumptionIncrement);
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
        
    }


}
