
//Name Price
//OutFall 4	    $39.99
//CS: OG	    $15.99
//Zplinter Zell	$19.99
//Honored 2	    $59.99
//RoverWatch	$29.99
//RoverWatch Origins Edition	$39.99
const double OF4 = 39.99;
const double CS = 15.99;
const double ZZ = 19.99;
const double H2 = 59.99;
const double RW = 29.99;
const double RWOE = 39.99;

var currentBalance = double.Parse(Console.ReadLine());
double originalBalance = currentBalance;

while (true)
{
    string command = Console.ReadLine();
    if (command == "Game Time")
    {
        Console.WriteLine($"Total spent: ${originalBalance-currentBalance:f2}. Remaining: ${currentBalance:f2}");
        break;
    }
    if (command == "OutFall 4")
    {
        if(currentBalance-OF4 < 0)
        {
            Console.WriteLine("Too Expensive");
        }else if(currentBalance-OF4 == 0)
        {
            currentBalance -= OF4;
            Console.WriteLine($"Bought {command}");
            Console.WriteLine("Out of money!");
            return;
        }
        else
        {
            currentBalance -= OF4;
            Console.WriteLine($"Bought {command}");
        }
    }
    else if (command == "CS: OG")
    {
        if (currentBalance - CS < 0)
        {
            Console.WriteLine("Too Expensive");
        }
        else if (currentBalance - CS == 0)
        {
            currentBalance -= CS;
            Console.WriteLine($"Bought {command}");
            Console.WriteLine("Out of money!");
            return;
        }
        else
        {
            currentBalance -= CS;
            Console.WriteLine($"Bought {command}");
        }

    }
    else if (command == "Zplinter Zell")
    {
        if (currentBalance - ZZ < 0)
        {
            Console.WriteLine("Too Expensive");
        }
        else if (currentBalance - ZZ == 0)
        {
            currentBalance -= ZZ;
            Console.WriteLine($"Bought {command}");
            Console.WriteLine("Out of money!");
            return;
        }
        else
        {
            currentBalance -= ZZ;
            Console.WriteLine($"Bought {command}");
        }
    }
    else if (command == "Honored 2")
    {
        if (currentBalance - H2 < 0)
        {
            Console.WriteLine("Too Expensive");
        }
        else if (currentBalance - H2 == 0)
        {
            currentBalance -= H2;
            Console.WriteLine($"Bought {command}");
            Console.WriteLine("Out of money!");
            return;
        }
        else
        {
            currentBalance -= H2;
            Console.WriteLine($"Bought {command}");
        }
    }
    else if (command == "RoverWatch")
    {
        if (currentBalance - RW < 0)
        {
            Console.WriteLine("Too Expensive");
        }
        else if (currentBalance - RW == 0)
        {
            currentBalance -= RW;
            Console.WriteLine($"Bought {command}");
            Console.WriteLine("Out of money!");
            return;
        }
        else
        {
            currentBalance -= RW;
            Console.WriteLine($"Bought {command}");
        }
    }
    else if (command == "RoverWatch Origins Edition")
    {
        if (currentBalance - RWOE < 0)
        {
            Console.WriteLine("Too Expensive");
        }
        else if (currentBalance - RWOE == 0)
        {
            currentBalance -= RWOE;
            Console.WriteLine($"Bought {command}");
            Console.WriteLine("Out of money!");
            return;
        }
        else
        {
            currentBalance -= RWOE;
            Console.WriteLine($"Bought {command}");
        }
    }
    else
    {
        Console.WriteLine("Not Found");
    }
    



}