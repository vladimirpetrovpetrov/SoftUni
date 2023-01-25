var lostGameCount = int.Parse(Console.ReadLine());

var headSetPrice = double.Parse(Console.ReadLine());
var mousePrice = double.Parse(Console.ReadLine());
var keyboardPrice = double.Parse(Console.ReadLine());
var displayPrice = double.Parse(Console.ReadLine());
int brokenHeadSet = 0;
int brokenMouse = 0;
int brokenKeyboard = 0;
int brokenDisplay = 0;





for (int i = 1; i <= lostGameCount; i++)
{
    if(i%2 == 0 && i%3 == 0)
    {
        brokenKeyboard++;
        brokenHeadSet++;
        brokenMouse++;
        if (brokenKeyboard % 2 == 0)
        {
            brokenDisplay++;
        }
    }else if (i % 2 == 0)
    {
        brokenHeadSet++;
    }else if (i% 3 == 0)
    {
        brokenMouse++;
    }
}

double totalExpenses = brokenHeadSet * headSetPrice + brokenMouse * mousePrice + keyboardPrice * brokenKeyboard + displayPrice * brokenDisplay;
Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");