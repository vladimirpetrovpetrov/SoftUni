using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles;

public class Truck : Vehicle
{
    const double increasedConsumption= 1.6;

    public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
        base.FuelConsumption += increasedConsumption;
    }
    public override void Refuel(double quantity)
    {
        FuelQuantity += quantity * 0.95;
    }
}
