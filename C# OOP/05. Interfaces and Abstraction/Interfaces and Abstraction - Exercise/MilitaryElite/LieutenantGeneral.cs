using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite;

internal class LieutenantGeneral : Private, ILieutenantGeneral
{
    public LieutenantGeneral(int id, string name, string lastName, decimal salary, IReadOnlyCollection<IPrivate> Privates) : base(id, name, lastName, salary)
    {
        this.Privates = Privates;
    }

    public IReadOnlyCollection<IPrivate> Privates { get; private set; }

    public override string ToString()
    {
        StringBuilder st = new StringBuilder();
        st.AppendLine(base.ToString());
        st.AppendLine("Privates:");
        foreach (var item in this.Privates)
        {
            st.AppendLine("  " + item.ToString());
        }
        return st.ToString().Trim();
    }
}