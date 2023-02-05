using System;
using System.Linq;
using System.Threading;

namespace _09._Jump_Around
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => byte.Parse(x)).ToArray();
            int collected = array[0];
            bool haveMove = true;
            int index = 0;
            int count = 0;
            int indexNow = 0;
            int move = array[0];
            while (true)
            {
                //Къде сме в момента (започваме от индекс 0 винаги)
                
                //колко стъпки ще местим
                if (indexNow + move < array.Length) //ако индекса на който сме + стъпките надясно са във обхвата на масива - мърдаме
                {
                    indexNow = indexNow + move; // вече сме на на новия индекс
                    move = array[indexNow]; //стъпките вече са други
                    collected += array[indexNow]; //събираме си числото на което сме стъпили
                }
                else
                {
                    count++;
                    indexNow = indexNow - move;
                    if (indexNow < 0)
                    {
                        Console.WriteLine(collected);
                        return;

                    }
                    collected += array[indexNow];
                    if (count == 2)
                    {
                        Console.WriteLine(collected);
                        return;
                    }
                    
                    move = array[indexNow];
                    if (indexNow + move >= array.Length)
                    {
                        count++;
                        Console.WriteLine(collected);
                        return;
                    }
                }
                count = 0;
            }
        }
    }
}
