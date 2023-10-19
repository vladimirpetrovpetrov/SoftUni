using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite;

internal class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(int id, string name, string lastName, decimal salary, Corps corp, IReadOnlyCollection<IRepair> repairs) : base(id, name, lastName, salary, corp)
    {
        Repairs = repairs;
    }

    public IReadOnlyCollection<IRepair> Repairs { get; private set; }
    public override string ToString()
    {
        StringBuilder st = new StringBuilder();
        st.AppendLine(base.ToString());
        st.AppendLine("Repairs:");
        foreach (var repair in Repairs)
        {
            st.AppendLine($"  {repair.ToString()}");
        }
        return st.ToString().Trim();
    }
}
