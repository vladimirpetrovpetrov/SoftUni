using Raiding.Models;
using Raiding.Models.Interfaces;

namespace Raiding;

public class Program
{
    static void Main(string[] args)
    {
        ICollection<IBaseHero> raidGroup = new List<IBaseHero>();
        var heroesToCreate = int.Parse(Console.ReadLine());
        while(heroesToCreate > raidGroup.Count)
        {
            var name = Console.ReadLine();
            var type = Console.ReadLine();
            switch (type)
            {
                case "Druid":
                    IBaseHero druid = new Druid(name);
                    raidGroup.Add(druid);
                    break;
                case "Paladin":
                    IBaseHero paladin = new Paladin(name);
                    raidGroup.Add(paladin);
                    break;
                case "Rogue":
                    IBaseHero rogue = new Rogue(name);
                    raidGroup.Add(rogue);
                    break;
                case "Warrior":
                    IBaseHero warrior = new Warrior(name);
                    raidGroup.Add(warrior);
                    break;
                default:
                    Console.WriteLine("Invalid hero!");
                    break;
            }
        }
        var bossPower = int.Parse(Console.ReadLine());
        int raidPower = 0;
        foreach (IBaseHero hero in raidGroup)
        {
            Console.WriteLine(hero.CastAbility());
            raidPower += hero.Power;
        }
        
        if(raidPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}