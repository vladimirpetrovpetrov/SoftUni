namespace OddLines
{
    using System.IO;
    using System.Text;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            var counter = 0;
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (counter % 2 != 0)
                {
                    writer.WriteLine(line);
                }
                counter++;
            }
            reader.Close();
            writer.Close();
        }
    }
}
