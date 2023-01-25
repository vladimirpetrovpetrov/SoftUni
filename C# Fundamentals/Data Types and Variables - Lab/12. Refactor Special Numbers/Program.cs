//int kolkko = int.Parse(Console.ReadLine());
//int obshto = 0;
//int takova = 0;
//bool toe = false;
//for (int ch = 1; ch <= kolkko; ch++)
//{
//    takova = ch;
//    while (ch > 0)
//    {
//        obshto += ch % 10;
//        ch = ch / 10;
//    }
//    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
//    Console.WriteLine("{0} -> {1}", takova, toe);
//    obshto = 0;
//    ch = takova;
//}

int numbersCount = int.Parse(Console.ReadLine());
int sumOfDigits = 0;

for (int i = 1; i <= numbersCount; i++)
{
    int oldI = i;
    while (i > 0)
    {
        sumOfDigits += i % 10;
        i = i / 10;
    }
    bool isItSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
    Console.WriteLine($"{oldI} -> {isItSpecial}");
    sumOfDigits = 0;
    i = oldI;
}
