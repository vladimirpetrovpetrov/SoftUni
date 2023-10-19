using ManufacturingPhones.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingPhones.Models;

public class Smartphone : ICallable, IBrowsable
{
    public string Call(string number)
    {
        if (!ValidateNumber(number))
        {
            throw new ArgumentException("Invalid number!");
        }
        return $"Calling... {number}";
    }
    public string Browse(string url)
    {
        if (!ValidateURL(url))
        {
            throw new ArgumentException("Invalid URL!");
        }
        return $"Browsing: {url}!";
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

    private bool ValidateURL(string url)
    {
        foreach (var item in url)
        {
            if (Char.IsDigit(item))
            {
                return false;
            }
        }
        return true;
    }
}
