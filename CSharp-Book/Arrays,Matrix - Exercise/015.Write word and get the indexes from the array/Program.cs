using System;

namespace Write_word_and_get_the_indexes_from_the_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];

            alphabet = InitArray(alphabet);
            Console.WriteLine("Write a word: ");
            CheckIndexes(Console.ReadLine().ToLower(),alphabet);
        }

        public static char[] InitArray(char[] arr)
        {
            var initilizer = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                arr[initilizer++] = i;
            }
            return arr;
        }
        public static void CheckIndexes(string word, char[] arr)
        {
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (word[i] == arr[j])
                    {
                        Console.WriteLine($"{word[i]} index in alphabet array is: {j}");
                        break;
                    }
                }
            }
        }
    }
}
