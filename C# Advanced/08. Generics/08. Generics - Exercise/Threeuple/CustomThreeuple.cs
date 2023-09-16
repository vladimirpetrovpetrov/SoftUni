using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple;

public class CustomThreeuple<T1,T2,T3>
{
    public CustomThreeuple(T1 itemOne, T2 itemTwo, T3 itemThree)
    {
        this.itemOne = itemOne;
        this.itemTwo = itemTwo;
        this.itemThree = itemThree;
    }

    public T1 itemOne { get; set; }
    public T2 itemTwo { get; set;}

    public T3 itemThree { get; set; }

    public override string ToString()
    {
        return $"{this.itemOne} -> {this.itemTwo} -> {this.itemThree}";
    }
}
