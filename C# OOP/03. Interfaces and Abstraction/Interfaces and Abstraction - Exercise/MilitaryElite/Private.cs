using MilitaryElite.Interfaces;

namespace MilitaryElite;

public class Private : Soldier, IPrivate
{
    public Private(int id, string name, string lastName, decimal salary) : base(id, name, lastName)
    {
        this.Salary = salary;
    }

    public decimal Salary { get; private set; }

    public override string ToString()
        => base.ToString() + $" Salary: {this.Salary:F2}";

}
