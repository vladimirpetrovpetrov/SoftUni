namespace Raiding.Models;

public class Paladin : BaseHero
{
    private const int paladinPower = 100;
    public Paladin(string name) : base(name, paladinPower)
    {
    }

    public override string CastAbility()
    {
        return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
    }

}
