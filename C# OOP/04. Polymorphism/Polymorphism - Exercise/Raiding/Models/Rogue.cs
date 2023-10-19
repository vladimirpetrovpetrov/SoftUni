namespace Raiding.Models;

public class Rogue : BaseHero
{
    private const int roguePower = 80;
    public Rogue(string name) : base(name, roguePower)
    {
    }

    public override string CastAbility()
    {
        return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
    }


}
