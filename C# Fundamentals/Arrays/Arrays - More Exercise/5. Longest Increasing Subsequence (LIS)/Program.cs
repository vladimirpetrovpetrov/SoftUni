var s = Console.ReadLine().Split().Select(int.Parse).ToArray();

int maxSeq = 1;
int seqNow = 1;

int biggerIndex = 0;
bool done = false;

for (int i = 0;i < s.Length; i++)
{
    int k = i+1;
    if(k == s.Length - 1)
    {
        break;
    }
    while(done == false)
    {
        if (k == s.Length - 1)
        {
            done = true;
        }
        seqNow = MaxSeq(s,s[i], k, s.Length);
        if (seqNow > maxSeq)
        {
            maxSeq = seqNow;
        }
        k++;
    }
    done = false;
}
Console.WriteLine(maxSeq);

int MaxSeq(int[] s,int proverqvanoChislo ,int i,int length)
{
    int seqM = 1;
    int seqN = 1;
    for (int j = i; j < length-1; j++)
    {
        if (proverqvanoChislo < s[j])
        {
            seqN++;

            if (seqN > seqM)
            {
                seqM = seqN;
            }
        } 
    }


    return seqM;
}
;