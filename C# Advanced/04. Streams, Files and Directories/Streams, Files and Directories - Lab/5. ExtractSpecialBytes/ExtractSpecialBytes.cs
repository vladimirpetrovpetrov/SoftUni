using System.IO;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            byte[] bytesToExtract = File.ReadAllBytes(bytesFilePath);
            byte[] inputBytes = File.ReadAllBytes(binaryFilePath);

            using (FileStream outputStream = new FileStream(outputPath, FileMode.Create))
            {
                foreach (byte b in bytesToExtract)
                {
                    for (int i = 0; i < inputBytes.Length; i++)
                    {
                        if (inputBytes[i] == b)
                        {
                            outputStream.WriteByte(inputBytes[i]);
                        }
                    }
                }
            }
        }
    }
}