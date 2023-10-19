namespace BorderControl;

public class StartUp
{
    static void Main(string[] args)
    {
        List<IIdentifiable> list = new List<IIdentifiable>();
        var input = " ";
        while(input != "End")
        {
            input = Console.ReadLine();
            if(input == "End")
            {
                break;
            }
            var splittedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            IIdentifiable identifiable;
            if(splittedInput.Length == 3)
            {
                identifiable = new Citizen(splittedInput[2]);
            }
            else
            {
                identifiable = new Robot(splittedInput[1]);
            }
            list.Add(identifiable);
        }
        var toRemove = Console.ReadLine();
        foreach (var item in list)
        {
            if (item.Id.EndsWith(toRemove))
            {
                Console.WriteLine(item.Id);
            }
        }

    }
}