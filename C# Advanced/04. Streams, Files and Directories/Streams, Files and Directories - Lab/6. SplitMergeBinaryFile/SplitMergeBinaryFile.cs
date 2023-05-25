using System;
using System.IO;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            byte[] sourceBytes = File.ReadAllBytes(sourceFilePath);
            int fileSize = sourceBytes.Length;

            int partOneSize = fileSize / 2;
            int partTwoSize = fileSize - partOneSize;

            byte[] partOneBytes = new byte[partOneSize];
            byte[] partTwoBytes = new byte[partTwoSize];

            Buffer.BlockCopy(sourceBytes, 0, partOneBytes, 0, partOneSize);
            Buffer.BlockCopy(sourceBytes, partOneSize, partTwoBytes, 0, partTwoSize);

            File.WriteAllBytes(partOneFilePath, partOneBytes);
            File.WriteAllBytes(partTwoFilePath, partTwoBytes);
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            byte[] partOneBytes = File.ReadAllBytes(partOneFilePath);
            byte[] partTwoBytes = File.ReadAllBytes(partTwoFilePath);

            byte[] joinedBytes = new byte[partOneBytes.Length + partTwoBytes.Length];

            Buffer.BlockCopy(partOneBytes, 0, joinedBytes, 0, partOneBytes.Length);
            Buffer.BlockCopy(partTwoBytes, 0, joinedBytes, partOneBytes.Length, partTwoBytes.Length);

            File.WriteAllBytes(joinedFilePath, joinedBytes);
        }
    }
}
