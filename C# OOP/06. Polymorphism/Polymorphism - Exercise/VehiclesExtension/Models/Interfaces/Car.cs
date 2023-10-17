using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models.Interfaces;

public class Car : Vehicle
{
    private const double fuelConsumptionIncrement = 0.9;

    public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
    {
    }
    public override double FuelConsumption =>
        base.FuelConsumption + fuelConsumptionIncrement;
}
