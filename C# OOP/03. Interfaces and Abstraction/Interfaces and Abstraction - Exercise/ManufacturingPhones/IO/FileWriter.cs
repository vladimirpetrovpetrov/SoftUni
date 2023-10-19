using ManufacturingPhones.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingPhones.IO;

public class FileWriter : IWriter
{
    public void WriteLine(string line)
    {
        string filePath = "../../../test.txt";

        using StreamWriter streamWriter = new(filePath,true);
        streamWriter.WriteLine(line);
    }
}
