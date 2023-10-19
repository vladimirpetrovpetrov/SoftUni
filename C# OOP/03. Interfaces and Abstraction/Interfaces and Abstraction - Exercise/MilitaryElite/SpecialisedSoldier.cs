using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite;
// CHECK NAME CORP/ CORPS
internal abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    protected SpecialisedSoldier(int id, string name, string lastName, decimal salary, Corps corp) : base(id, name, lastName, salary)
    {
        Corp = corp;
    }

    public Corps Corp { get; private set; }
    public override string ToString()
        => base.ToString() + $"{Environment.NewLine}Corps: {this.Corp}";

}
