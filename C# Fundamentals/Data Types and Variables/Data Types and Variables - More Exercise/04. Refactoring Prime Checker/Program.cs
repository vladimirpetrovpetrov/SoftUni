//int ___Do___ = int.Parse(Console.ReadLine());
//for (int takoa = 2; takoa <= ___Do___; takoa++)
//{
//    bool takovalie = true;
//    for (int cepitel = 2; cepitel < takoa; cepitel++)
//    {
//        if (takoa % cepitel == 0)
//        {
//            takovalie = false;
//            break;
//        }
//    }
//    Console.WriteLine("{0} -> {1}", takoa, takovalie);
//}


int endNum = int.Parse(Console.ReadLine());
for (int startNum = 2; startNum <= endNum; startNum++)
{
    bool isPrime = true;
    for (int divisor = 2; divisor < startNum; divisor++)
    {
        if (startNum % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine($"{startNum} -> true");
    }
    else
    {
        Console.WriteLine($"{startNum} -> false");
    }
}
