using MilitaryElite.Interfaces;

namespace MilitaryElite;

public abstract class Soldier : ISoldier
{
    protected Soldier(int id, string name, string lastName)
    {
        Id = id;
        Name = name;
        LastName = lastName;
    }

    public int Id { get; private set; }

    public string Name { get; private set; }


    public string LastName { get; private set; }

    public override string ToString()
    => $"Name: {this.Name} {this.LastName} Id: {this.Id}";
    
}
