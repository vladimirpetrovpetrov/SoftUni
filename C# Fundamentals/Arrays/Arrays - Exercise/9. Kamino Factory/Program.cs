var lengthOfDNA = int.Parse(Console.ReadLine());
string command = string.Empty;

int startingIndex = 0;
int sampleNumber = 0;
int bestSampleNumber = 1;
int biggestSeq = 1;
int biggestSeqATM = 1;
int sum = 0; int bestSum = 0;
while (command != "Clone them!")
{
    
    command = Console.ReadLine();
    if (command == "Clone them!")
    {
        break;
    }
    var arr = command.Split('!').Select(int.Parse).ToArray();
    sampleNumber++;
    sum = arr.Sum();

    for (int i = 0; i < arr.Length; i++)
    {

        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] == 1 & arr[i] == arr[j])
            {
                biggestSeqATM++; //
                if (biggestSeqATM > biggestSeq)
                {
                    biggestSeq = biggestSeqATM; //
                    startingIndex = i; //
                    bestSampleNumber= sampleNumber;
                    bestSum = sum;
                }
            }
            else
            {
                biggestSeqATM = 1;
                break;
            }
        }
        biggestSeqATM = 1;
    }




}

Console.WriteLine($"Starting index = {startingIndex}");
Console.WriteLine($"best biggest seq = {biggestSeq}");
Console.WriteLine($"Best sample number = {bestSampleNumber}");
Console.WriteLine($"Best sum = {bestSum}");














