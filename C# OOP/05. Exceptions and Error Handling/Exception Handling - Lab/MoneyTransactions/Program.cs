namespace MoneyTransactions;

internal class Program
{
    static void Main(string[] args)
    {
        List<BankAccount> bankAccs = new List<BankAccount>();
        var accInfos = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
        foreach (var acc in accInfos)
        {
            var accNum = acc.Split("-", StringSplitOptions.RemoveEmptyEntries)[0];
            var accSum = double.Parse(acc.Split("-", StringSplitOptions.RemoveEmptyEntries)[1]);
            bankAccs.Add(new BankAccount(accNum, accSum));
        }

        var commandTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        while (commandTokens[0] != "End")
        {
            if (commandTokens[0] == "End")
            {
                break;
            }
            var command = commandTokens[0];
            var num = commandTokens[1];
            var sum = double.Parse(commandTokens[2]);
            var validNum = bankAccs.Find(ba => ba.Number == num);
            try
            {
                switch (command)
                {
                    case "Withdraw":
                        validNum.Withdraw(num, sum);
                        break;
                    case "Deposit":
                        validNum.Deposit(num, sum);
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Invalid account!");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
        NewCommand();

            }
        commandTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }


    }
    public static void NewCommand()
    {
        Console.WriteLine("Enter another command");
    }
}