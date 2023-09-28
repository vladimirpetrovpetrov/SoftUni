using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite;

internal class Commando : SpecialisedSoldier, ICommando
{
    public Commando(int id, string name, string lastName, decimal salary, Corps corp, IReadOnlyCollection<IMission> missions) : base(id, name, lastName, salary, corp)
    {
        Missions = missions;
    }

    public IReadOnlyCollection<IMission> Missions { get; private set; }
    public override string ToString()
    {
        StringBuilder st = new StringBuilder();
        st.AppendLine(base.ToString());
        st.AppendLine("Missions:");
        foreach (var mission in Missions)
        {
            st.AppendLine($"  {mission.ToString()}");
        }
        return st.ToString().Trim();
    }
}
