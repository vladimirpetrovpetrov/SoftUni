using System;

namespace _06._The_Most_Powerful_Word
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string word = Console.ReadLine();
            string wordCopy = word.ToLower();
            double sum = 0.0;
            string maxPowerWordName = "";
            double MaxPowerPoints = double.MinValue;
            while (word != "End of words")
            {
                int lengthWord = word.Length;
                for (int i = 0; i < lengthWord; i++)
                {
                    sum += word[i];
                }
                if (wordCopy[0] == 'a' || wordCopy[0] == 'e' || wordCopy[0] == 'i'
                    || wordCopy[0] == 'o' || wordCopy[0] == 'u' || wordCopy[0] == 'y')
                {
                    sum *= lengthWord;
                }
                else
                {
                    sum /= lengthWord;
                    sum = Math.Floor(sum);
                }
                if (sum >= MaxPowerPoints)
                {
                    MaxPowerPoints = sum;
                    maxPowerWordName = word;
                }

                sum = 0.0;
                word = Console.ReadLine();
                wordCopy = word.ToLower();
            }
            Console.WriteLine($"The most powerful word is {maxPowerWordName} - {MaxPowerPoints}");






        }
    }
}
