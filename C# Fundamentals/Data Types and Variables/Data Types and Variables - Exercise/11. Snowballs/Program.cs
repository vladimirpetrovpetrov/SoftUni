using System.Numerics;

var totalSnowBalls = int.Parse(Console.ReadLine());

if(totalSnowBalls == 0)
{
    Console.WriteLine("0 : 0 = 0 (0)");
    return;
}
BigInteger bestSnowballValue = 0;
BigInteger snowballValue = 0;
BigInteger bestSnowBallSnow = 0;
BigInteger bestSnowBallTime = 0;
BigInteger bestSnowBallQuality = 0;


for (int i = 0; i < totalSnowBalls; i++)
{

    var snowballSnow = int.Parse(Console.ReadLine());
    var snowballTime = int.Parse(Console.ReadLine());
    var snowballQuality = int.Parse(Console.ReadLine());

    snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
    if (snowballValue > bestSnowballValue)
    {
        bestSnowballValue = snowballValue;
        bestSnowBallSnow = snowballSnow;
        bestSnowBallTime = snowballTime;
        bestSnowBallQuality = snowballQuality;
    }
    snowballValue = 0;
}
Console.WriteLine($"{bestSnowBallSnow} : {bestSnowBallTime} = {bestSnowballValue} ({bestSnowBallQuality})");