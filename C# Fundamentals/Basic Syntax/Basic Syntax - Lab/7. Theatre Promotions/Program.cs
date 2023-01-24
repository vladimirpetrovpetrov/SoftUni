var day = Console.ReadLine();

var age = int.Parse(Console.ReadLine());
if(age<0 || age > 122)
{
    Console.WriteLine("Error!");
}

switch (day)
{
    case "Weekday":
        if(age>=0 && age <= 18)
        {
            Console.WriteLine("12$");
        }else if (age > 18 && age <= 64)
        {
            Console.WriteLine("18$");
        }
        else if (age > 64 && age <= 122)
        {
            Console.WriteLine("12$");
        }
        break;
    case "Weekend":
        if (age >= 0 && age <= 18)
        {
            Console.WriteLine("15$");
        }
        else if (age > 18 && age <= 64)
        {
            Console.WriteLine("20$");
        }
        else if (age > 64 && age <= 122)
        {
            Console.WriteLine("15$");
        }
        break;
    case "Holiday":
        if (age >= 0 && age <= 18)
        {
            Console.WriteLine("5$");
        }
        else if (age > 18 && age <= 64)
        {
            Console.WriteLine("12$");
        }
        else if (age > 64 && age <= 122)
        {
            Console.WriteLine("10$");
        }
        break;

    default:
        break;
}