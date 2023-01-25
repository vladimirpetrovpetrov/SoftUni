var pokePower = int.Parse(Console.ReadLine());//5
var distance = int.Parse(Console.ReadLine());//2
var exhaustionFactor = byte.Parse(Console.ReadLine());//3

int pokedTargets = 0;
int originalPokePower = pokePower;


while (pokePower >= distance)
{
    
    if (originalPokePower / pokePower == 2 && originalPokePower % pokePower == 0 && exhaustionFactor != 0)
    {
        pokePower /= exhaustionFactor;
        if (pokePower < distance)
        {
            break;
        }
    } 
    pokedTargets++;
    pokePower -= distance;
}
Console.WriteLine(pokePower);
Console.WriteLine(pokedTargets);