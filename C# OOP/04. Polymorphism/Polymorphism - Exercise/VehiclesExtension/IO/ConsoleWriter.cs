using VehiclesExtension.IO.Interfaces;

namespace VehiclesExtension.IO;

public class ConsoleWriter : IWriter
{
    public void Write(string text)
        => Console.Write(text);

    public void WriteLine(string text)
        => Console.WriteLine(text);
}
