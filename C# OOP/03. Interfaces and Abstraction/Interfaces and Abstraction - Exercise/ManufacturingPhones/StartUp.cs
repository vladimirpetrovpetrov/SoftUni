using ManufacturingPhones.Core;
using ManufacturingPhones.Core.Interfaces;
using ManufacturingPhones.IO;
using ManufacturingPhones.Models;
using ManufacturingPhones.Models.Interfaces;

namespace ManufacturingPhones;

public class StartUp
{
    static void Main(string[] args)
    {
        IEngine engine = new Engine(new ConsoleReader(), new ConsoleWriter());
        engine.Run();
    }
}