namespace PlayCatch;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        CustomArray customArray = new CustomArray(numbers);
        while (customArray.errors < 3)
        {
            var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            int endIndex = 0;
            try
            {
                index = int.Parse(command[1]);
                if (command.Length > 2)
                {
                    endIndex = int.Parse(command[2]);
                }
            }
            catch (FormatException e)
            {
                customArray.errors += 1;
                Console.WriteLine("The variable is not in the correct format!");
                continue;
            }
            try
            {
                switch (command[0])
                {

                    case "Replace":
                        customArray.Replace(index, endIndex);
                        break;
                    case "Show":
                        customArray.Show(index);
                        break;
                    case "Print":
                        customArray.Print(index, endIndex);
                        break;
                    default:
                        break;
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                customArray.errors += 1;
            }
            
        }
        Console.WriteLine(String.Join(", ", customArray.ints));


    }
}