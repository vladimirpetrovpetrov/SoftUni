using Vehicles.Core;
using Vehicles.Core.Interfaces;
using Vehicles.Factories.Interfaces;
using Vehicles.Factories;
using Vehicles.IO.Interfaces;
using Vehicles.IO;

namespace Vehicles;

public class StartUp
{
    static void Main(string[] args)
    {
        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        IVehicleFactory vehicleFactory = new VehicleFactory();

        IEngine engine = new Engine(reader, writer, vehicleFactory);

        engine.Run();
    }
}