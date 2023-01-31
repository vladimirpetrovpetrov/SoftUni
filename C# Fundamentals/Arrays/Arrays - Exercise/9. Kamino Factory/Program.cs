var lengthOfDNA = int.Parse(Console.ReadLine());
string command = string.Empty;
int[] bestDNAarray = new int[lengthOfDNA];



int latestDNAnumber = 0;
int dnaNumber = 0;
int biggestSeq = 1;
int seqNow = 1;
int bestDNAnumber = 0;
int latestIndex = 0;
int BestLatestIndex = int.MaxValue;
int sumNow = 0;
int bestSum = 0;



while (command != "Clone them!")
{

    command = Console.ReadLine();
    if (command == "Clone them!")
    {
        break;
    }
    dnaNumber++;
    latestDNAnumber = dnaNumber;
    var arr = command.Split('!',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    sumNow = arr.Sum();
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1] && arr[i] == 1)
        {
            seqNow++;
            latestIndex = i + 1;
            if (seqNow > biggestSeq)
            {
                biggestSeq = seqNow;
                bestDNAnumber = latestDNAnumber;
                BestLatestIndex = latestIndex;
                bestSum = sumNow;
                bestDNAarray = arr;
            }
            else if (seqNow == biggestSeq)
            {
                if (latestIndex < BestLatestIndex)
                {
                    BestLatestIndex = latestIndex;
                    biggestSeq = seqNow;
                    bestDNAnumber = latestDNAnumber;
                    bestSum = sumNow;
                    bestDNAarray = arr;
                }
                else if (latestIndex == BestLatestIndex)
                {
                    if (sumNow > bestSum)
                    {
                        BestLatestIndex = latestIndex;
                        biggestSeq = seqNow;
                        bestDNAnumber = latestDNAnumber;
                        bestSum = sumNow;
                        bestDNAarray = arr;
                    }
                }
            }
        }
        else
        {
            seqNow = 1;
        }
    }
    seqNow = 1;
}

Console.WriteLine($"Best DNA sample {bestDNAnumber} with sum: {bestSum}.");
Console.WriteLine(String.Join(" ", bestDNAarray));
