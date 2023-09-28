using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite;

internal class Spy : Soldier, ISpy
{
    public Spy(int id, string name, string lastName, int codeNumber) : base(id, name, lastName)
    {
        CodeNumber = codeNumber;
    }

    public int CodeNumber { get; private set; }
    public override string ToString()
    {
        return base.ToString() + $"{Environment.NewLine}Code Number: {this.CodeNumber}";
    }
}
