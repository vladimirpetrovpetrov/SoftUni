using ManufacturingPhones.Core.Interfaces;
using ManufacturingPhones.Models.Interfaces;
using ManufacturingPhones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using ManufacturingPhones.IO.Interfaces;

namespace ManufacturingPhones.Core;

public class Engine : IEngine
{
    private IReader reader;
    private IWriter writer;
    public Engine(IReader reader, IWriter writer)
    {
        this.reader = reader;
        this.writer = writer;
    }
    public void Run()
    {
        var numbers = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        var urls = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        ICallable phone;
        foreach (var number in numbers)
        {
            if (number.Length == 10)
            { 
                phone = new Smartphone();
            }
            else
            {
                phone = new StationaryPhone();
            }
            try
            {
                writer.WriteLine(phone.Call(number));
            }
            catch (Exception e)
            {

                writer.WriteLine(e.Message);
            }
        }
        IBrowsable sp = new Smartphone();
        foreach (var url in urls)
        {
            try
            {
                writer.WriteLine(sp.Browse(url));
            }
            catch (Exception e)
            {
                writer.WriteLine(e.Message);
            }
        }
    }
}

