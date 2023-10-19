using WildFarm.Models;
using WildFarm.Models.Interfaces;

namespace WildFarm;

public class StartUp
{
    static void Main(string[] args)
    {
        List<IAnimal> animals = new List<IAnimal>();
        List<IFood> food = new List<IFood>();
        var inputAnimal = "";
        while(inputAnimal != "End")
        {
            inputAnimal = Console.ReadLine();
            if(inputAnimal == "End")
            {
                break;
            }
            var aTokens = inputAnimal.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var typeAnimal = aTokens[0];
            var animalName = aTokens[1];
            var inputFood = Console.ReadLine();
            var fTokens = inputFood.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var foodType = fTokens[0];
            var foodQuantity = int.Parse(fTokens[1]);
            switch (foodType)
            {
                case "Vegetable":
                    IFood vegetable = new Vegetable(foodQuantity);
                    food.Add(vegetable);
                    break;
                case "Meat":
                    IFood meat = new Meat(foodQuantity);
                    food.Add(meat);
                    break;
                case "Seeds":
                    IFood seeds = new Seeds(foodQuantity);
                    food.Add(seeds);
                    break;
                case "Fruit":
                    IFood fruit = new Fruit(foodQuantity);
                    food.Add(fruit);
                    break;
                default:
                    break;
            }
            var currentFood = food.Last();
            switch (typeAnimal)
            {
                case "Cat":
                    IAnimal cat = new Cat(animalName, double.Parse(aTokens[2]), aTokens[3], aTokens[4]);
                    animals.Add(cat);
                    break;
                case "Tiger":
                    IAnimal tiger = new Tiger(animalName, double.Parse(aTokens[2]), aTokens[3], aTokens[4]);
                    animals.Add(tiger);
                    break;
                case "Owl":
                    IAnimal owl = new Owl(animalName, double.Parse(aTokens[2]), double.Parse(aTokens[3]));
                    animals.Add(owl);
                    break;
                case "Hen":
                    IAnimal hen = new Hen(animalName, double.Parse(aTokens[2]), double.Parse(aTokens[3]));
                    animals.Add(hen);
                    break;
                case "Dog":
                    IAnimal dog = new Dog(animalName, double.Parse(aTokens[2]), aTokens[3]);
                    animals.Add(dog);
                    break;
                case "Mouse":
                    IAnimal mouse = new Mouse(animalName, double.Parse(aTokens[2]), aTokens[3]);
                    animals.Add(mouse);
                    break;
                default:
                    break;
            }
            var currentAnimal = animals.Last();
            currentAnimal.ProduceSound();
            currentAnimal.Eat(currentFood);
        }
        foreach(IAnimal animal in animals)
        {
            Console.WriteLine(animal);
        }
    }
}

//animal initialize
//food initialize
//animal sound (print)
//try to feed
// after end coomand print all animals
