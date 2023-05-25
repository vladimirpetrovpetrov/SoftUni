using System;
using System.IO;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] firstLines = File.ReadAllLines(firstInputFilePath);
            string[] secondLines = File.ReadAllLines(secondInputFilePath);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                int maxLength = Math.Max(firstLines.Length, secondLines.Length);

                for (int i = 0; i < maxLength; i++)
                {
                    if (i < firstLines.Length)
                    {
                        writer.WriteLine(firstLines[i]);
                    }

                    if (i < secondLines.Length)
                    {
                        writer.WriteLine(secondLines[i]);
                    }
                }
            }
        }
    }
}
