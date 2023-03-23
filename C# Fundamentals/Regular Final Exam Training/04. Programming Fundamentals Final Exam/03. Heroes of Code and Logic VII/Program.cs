using System.Text;

var n = int.Parse(Console.ReadLine());
var heroes = new Dictionary<string, List<int>>();
for (int i = 0; i < n; i++)
{
    var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    var name = input[0];
    var hp = int.Parse(input[1]);
    if (hp > 100)
    {
        hp = 100;
    }
    var mp = int.Parse(input[2]);
    if (mp > 200)
    {
        mp = 200;
    }
    heroes[name] = new List<int> { hp, mp };
}
while (true)
{
    var command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries);
    if (command[0] == "End")
    {
        break;
    }

    if (command[0] == "CastSpell")
    {
        var name = command[1];
        var mpNeeded = int.Parse(command[2]);
        var spellName = command[3];
        if (heroes[name][1] < mpNeeded)
        {
            Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
            continue;
        }
        heroes[name][1] -= mpNeeded;
        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name][1]} MP!");
    }else if (command[0] == "TakeDamage")
    {
        var name = command[1];
        var damage = int.Parse(command[2]);
        var attacker = command[3];
        if (heroes[name][0] > damage)
        {
            heroes[name][0] -= damage;
            Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name][0]} HP left!");
        }
        else
        {
            heroes.Remove(name);
            Console.WriteLine($"{name} has been killed by {attacker}!");
        }
    }else if (command[0] == "Recharge")
    {
        var name = command[1];
        var amount = int.Parse(command[2]);
        if (heroes[name][1] + amount > 200)
        {
            amount = 200 - heroes[name][1];
            heroes[name][1] = 200;
            Console.WriteLine($"{name} recharged for {amount} MP!");
            continue;
        }
        heroes[name][1] += amount;
        Console.WriteLine($"{name} recharged for {amount} MP!");
    }
    else if (command[0] == "Heal")
    {
        var name = command[1];
        var amount = int.Parse(command[2]);
        if (heroes[name][0] + amount > 100)
        {
            amount = 100 - heroes[name][0];
            heroes[name][0] = 100;
            Console.WriteLine($"{name} healed for {amount} HP!");
            continue;
        }
        heroes[name][0] += amount;
        Console.WriteLine($"{name} healed for {amount} HP!");
    }
}
StringBuilder st = new StringBuilder();
foreach (var item in heroes)
{
    st.AppendLine(@$"{item.Key}
  HP: {item.Value[0]}
  MP: {item.Value[1]}"
);
}
Console.WriteLine(st.ToString());