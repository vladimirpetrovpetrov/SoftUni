//•	"Nuts" with a price of 2.0
//•	"Water" with a price of 0.7
//•	"Crisps" with a price of 1.5
//•	"Soda" with a price of 0.8
//•	"Coke" with a price of 1.0

const double priceNuts = 2.0;
const double priceWater = 0.7;
const double priceCrisps = 1.5;
const double priceSoda = 0.8;
const double priceCoke = 1.0;

double totalMoney = 0;
bool validProduct = true;

string command = "";
while (command != "Start")
{
    command = Console.ReadLine();
    if (command == "Start")
    {
        while (command != "End")
        {
            command = Console.ReadLine();
            if (command == "End")
            {
                Console.WriteLine($"Change: {totalMoney:f2}");
                return;
            }
            double oldTotalMoney = totalMoney;
            if (command == "Nuts")
            {
                totalMoney -= priceNuts;
            }
            else if (command == "Water")
            {
                totalMoney -= priceWater;
            }
            else if (command == "Crisps")
            {
                totalMoney -= priceCrisps;
            }
            else if (command == "Soda")
            {
                totalMoney -= priceSoda;
            }
            else if (command == "Coke")
            {
                totalMoney -= priceCoke;
            }
            else
            {
                validProduct = false;
            }
            if(totalMoney >= 0 && validProduct)
            {
                Console.WriteLine($"Purchased {command.ToLower()}");
            }
            else if (!validProduct)
            {
                Console.WriteLine("Invalid product");
            }
            else
            {
                Console.WriteLine("Sorry, not enough money");
                totalMoney = oldTotalMoney;
            }
            validProduct = true;


        }
    }
    if (double.Parse(command) != 1 &&
       double.Parse(command) != 2 &&
       double.Parse(command) != 0.5 &&
       double.Parse(command) != 0.2 &&
       double.Parse(command) != 0.1
        )
    {
        Console.WriteLine($"Cannot accept {command}");
    }
    else
    {
        totalMoney += double.Parse(command);
    }
}
Console.WriteLine(totalMoney);
