using ManufacturingPhones.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingPhones.IO;

public class ConsoleWriter : IWriter
{
    public void WriteLine(string line)
        => Console.WriteLine(line);
}
