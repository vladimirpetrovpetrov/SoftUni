using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        var pokemons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        List<int> catchedPokemons = new List<int>();
        while (pokemons.Count > 0)
        {
            var index = int.Parse(Console.ReadLine());
            int lastPokemon;
            if (index < 0)
            {
                int temp = pokemons[pokemons.Count - 1];
                lastPokemon = pokemons[0];
                pokemons.RemoveAt(0);
                pokemons.Insert(0, temp);
                IncreaseDecrease(pokemons, lastPokemon);
            }
            else if (index > pokemons.Count - 1)
            {
                int temp = pokemons[0];
                lastPokemon = pokemons[pokemons.Count - 1];
                pokemons.RemoveAt(pokemons.Count - 1);
                pokemons.Add(temp);

                IncreaseDecrease(pokemons, lastPokemon);
            }
            else
            {
                lastPokemon = pokemons[index];
                pokemons.RemoveAt(index);
                IncreaseDecrease(pokemons, lastPokemon);

            }
            catchedPokemons.Add(lastPokemon);
        }
        Console.WriteLine(catchedPokemons.Sum());
    }
    private static void IncreaseDecrease(List<int> pokemons, int lastPokemon)
    {
        for (int i = 0; i < pokemons.Count; i++)
        {
            if (pokemons[i] <= lastPokemon)
            {
                pokemons[i] += lastPokemon;
            }
            else if (pokemons[i] > lastPokemon)
            {
                pokemons[i] -= lastPokemon;
            }
        }
    }
}