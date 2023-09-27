using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManufacturingPhones.Models.Interfaces;

public interface ICallable
{
    public string Call(string number);
}
