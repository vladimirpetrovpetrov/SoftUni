using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple;

public class CustomTuple<Tkey,Tvalue>
{
    public CustomTuple(Tkey itemOne, Tvalue itemTwo)
    {
        this.itemOne = itemOne;
        this.itemTwo = itemTwo;
    }

    public Tkey itemOne { get; set; }
    public Tvalue itemTwo { get; set;}

    public override string ToString()
    {
        return $"{this.itemOne} -> {this.itemTwo}";
    }
}
