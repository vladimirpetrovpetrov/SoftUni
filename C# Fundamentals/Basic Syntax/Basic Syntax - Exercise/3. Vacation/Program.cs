var count = int.Parse(Console.ReadLine());
var typeOfGroup = Console.ReadLine();
var dayOfTheWeek = Console.ReadLine();

double pricePerPerson = 0;
switch (typeOfGroup)
{
	case "Students":
		if(dayOfTheWeek == "Friday")
		{
			pricePerPerson = 8.45;
		}
        else if (dayOfTheWeek == "Saturday")
        {
            pricePerPerson = 9.80;
        }
        else if (dayOfTheWeek == "Sunday")
        {
            pricePerPerson = 10.46;
        }
        break;
    case "Business":
        if (dayOfTheWeek == "Friday")
        {
            pricePerPerson = 10.90;
        }
        else if (dayOfTheWeek == "Saturday")
        {
            pricePerPerson = 15.60;
        }
        else if (dayOfTheWeek == "Sunday")
        {
            pricePerPerson = 16;
        }
        break;
    case "Regular":
        if (dayOfTheWeek == "Friday")
        {
            pricePerPerson = 15;
        }
        else if (dayOfTheWeek == "Saturday")
        {
            pricePerPerson = 20;
        }
        else if (dayOfTheWeek == "Sunday")
        {
            pricePerPerson = 22.50;
        }
        break;
    default:
		break;
}

double totalPrice = count * pricePerPerson;
if(typeOfGroup == "Students" && count >= 30)
{
    totalPrice *= 0.85; 
}else if (typeOfGroup == "Business" && count >= 100)
{
    totalPrice -= (10*pricePerPerson);
}
else if (typeOfGroup == "Regular" && (count >= 10 && count <= 20))
{
    totalPrice *= 0.95;
}
Console.WriteLine($"Total price: {totalPrice:f2}");