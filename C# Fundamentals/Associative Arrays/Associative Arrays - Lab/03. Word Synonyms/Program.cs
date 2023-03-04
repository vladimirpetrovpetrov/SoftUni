namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main()
        {
            // word is the key
            // synonyms are the value and are in a list
            int keyWordsCount = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < keyWordsCount; i++)
            {
                var keyWord = Console.ReadLine();
                if (!dict.ContainsKey(keyWord))
                {
                    dict.Add(keyWord, new List<string>());
                }
                var theValue = Console.ReadLine();
                if(theValue != keyWord && !dict[keyWord].Contains(theValue))
                {
                    dict[keyWord].Add(theValue);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {String.Join(", ",item.Value)}");
            }





        }
    }
}