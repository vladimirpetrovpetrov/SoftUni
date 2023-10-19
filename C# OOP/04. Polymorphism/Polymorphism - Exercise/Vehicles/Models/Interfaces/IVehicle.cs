using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models.Interfaces;

public interface IVehicle
{
    double FuelQuantity { get;}
    double FuelConsumption { get;}
    void Drive(double distance);
    void Refuel(double liters);



}
