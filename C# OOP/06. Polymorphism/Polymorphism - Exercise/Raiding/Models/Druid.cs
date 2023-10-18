namespace Raiding.Models;

public class Druid : BaseHero
{
    private const int druidPower = 80;
    public Druid(string name) : base(name, druidPower)
    {
    }

    public override string CastAbility()
    {
        return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
    }
}
