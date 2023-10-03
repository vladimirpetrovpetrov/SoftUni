using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles;

public class Car : Vehicle
{
    const double increasedConsumption = 0.9;

    public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
    {
        base.FuelConsumption += increasedConsumption;
    }
}
