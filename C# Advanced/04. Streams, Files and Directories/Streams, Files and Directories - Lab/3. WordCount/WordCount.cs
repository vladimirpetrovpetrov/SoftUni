using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            StreamReader wordReader = new StreamReader(wordsFilePath);
            StreamReader textReader = new StreamReader(textFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);

            var words = wordReader.ReadToEnd().Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            wordReader.Close();

            string[] delimiters = { " ", "\t", "\n", "\r", ".", ",", ";", ":", "!", "?", "-", "_", "(", ")", "[", "]", "{", "}" };
            var text = textReader.ReadToEnd().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            textReader.Close();

            var dict = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            foreach (var word in words)
            {
                var count = text.Count(w => string.Equals(w, word, StringComparison.InvariantCultureIgnoreCase));
                dict[word] = count;
            }

            foreach (var pair in dict.OrderByDescending(x => x.Value))
            {
                writer.WriteLine($"{pair.Key} - {pair.Value}");
            }

            writer.Close();
        }
    }
}
