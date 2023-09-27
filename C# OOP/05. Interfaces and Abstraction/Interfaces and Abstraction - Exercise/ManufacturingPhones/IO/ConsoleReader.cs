using ManufacturingPhones.IO.Interfaces;

namespace ManufacturingPhones.IO;

public class ConsoleReader : IReader
{
    public string ReadLine()
        => Console.ReadLine();
}
