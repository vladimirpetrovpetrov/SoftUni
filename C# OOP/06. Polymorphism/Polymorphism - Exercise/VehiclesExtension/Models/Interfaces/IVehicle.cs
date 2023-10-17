using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models.Interfaces;

public interface IVehicle
{
    double FuelQuantity { get;}
    double FuelConsumption { get;}
    double TankCapacity { get; }
    bool IsEmpty { get; }
    void Drive(double distance);
    void Refuel(double liters);



}
