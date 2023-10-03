using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles;
//CHECK FOR ENCAPSULATION IF NEEDED
public abstract class Vehicle
{
    private double increasedConsumption;

    protected Vehicle(double fuelQuantity, double fuelConsumption)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public double FuelQuantity { get; set; }
    public double FuelConsumption { get; set; } // L/km
    public void Drive(double distance)
    {
        double consumption = distance * FuelConsumption;
        if (consumption <= FuelQuantity)
        {
            FuelQuantity -= consumption;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
        else
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
    }
    public virtual void Refuel(double quantity)
    {
        FuelQuantity += quantity;
    }





}
