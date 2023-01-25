var money = double.Parse(Console.ReadLine());
var studentCount = int.Parse(Console.ReadLine());
var lsPrice = double.Parse(Console.ReadLine());
var robePrice = double.Parse(Console.ReadLine());
var beltPrice = double.Parse(Console.ReadLine());

lsPrice = lsPrice * Math.Ceiling(studentCount * 1.10);
robePrice *= studentCount;//вярно
int freeBelts = studentCount / 6; //вярно
beltPrice *= (studentCount - freeBelts);//вярно
var totalCost = lsPrice + robePrice + beltPrice;

if (totalCost <= money)
{
    Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {Math.Abs(money-totalCost):f2}lv more.");
}



