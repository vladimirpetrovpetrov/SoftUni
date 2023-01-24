using System;
using System.ComponentModel;

namespace TEST
{

//      RECURSIVE 

internal class Program
{
static int[] loops;
static int numberOfLoops;
static int stop;

static void Main(string[] args)
{
numberOfLoops = 4;
stop = 3;
loops = new int[numberOfLoops];
NestedLoops(0);
}
static void NestedLoops(int currentLoop)
{
if (currentLoop == numberOfLoops)
{
PrintLoops(loops);
return;
}

for (int i = 1; i <= stop; i++)
{
loops[currentLoop] = i;
NestedLoops(currentLoop + 1);
}
}
static void PrintLoops(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr[i]} ");
}
Console.WriteLine();
}
}
}


