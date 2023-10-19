using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models.Interfaces;

public class Car : Vehicle
{
    private const double FuelConsumptionIncrement = 0.9;

    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity, FuelConsumptionIncrement)
    {
    }
}
