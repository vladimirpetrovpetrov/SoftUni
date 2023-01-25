var username = Console.ReadLine();
string rightPass = "";
for (int i = 0; i < username.Length; i++)
{
    rightPass += username[username.Length - i - 1];
}

var loggedPass = "";
int trys = 4;
while (loggedPass != rightPass && trys > 0)
{
    loggedPass = Console.ReadLine();
    trys--;
    if (trys == 0)
    {
        Console.WriteLine($"User {username} blocked!");
        break;
    }
    if (loggedPass == rightPass)
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }
    Console.WriteLine("Incorrect password. Try again.");
}