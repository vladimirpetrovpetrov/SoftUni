var n = Console.ReadLine();
switch (n)
{
	case "England":
    case "USA":
        Console.WriteLine("English");
        break;
    case "Spain":
    case "Argentina":
    case "Mexico":
        Console.WriteLine("Spanish");
        break;
    default:
        Console.WriteLine("unknown");
		break;
}