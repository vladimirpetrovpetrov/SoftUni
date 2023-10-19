using ManufacturingPhones.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingPhones.Models;

public class StationaryPhone : ICallable
{

    public string Call(string number)
    {
        if (!ValidateNumber(number))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Dialing... {number}";
    }
    private bool ValidateNumber(string number)
    {
        foreach (var item in number)
        {
            if (!Char.IsDigit(item))
            {
                return false;
            }
        }
        return true;
    }
}
