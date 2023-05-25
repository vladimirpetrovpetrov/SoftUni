namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long totalSize = CalculateFolderSize(folderPath);

            double sizeInKilobytes = totalSize / 1024.0;

            string outputText = $"{sizeInKilobytes} KB";

            File.WriteAllText(outputFilePath, outputText);
        }

        private static long CalculateFolderSize(string folderPath)
        {
            long totalSize = 0;

            foreach (string filePath in Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                totalSize += fileInfo.Length;
            }

            return totalSize;
        }

    }
}
