using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            try
            {
                long totalSizeBytes = CalculateFolderSize(folderPath);

                double totalSizeKb = totalSizeBytes / 1024.0;

                using (StreamWriter writer = new StreamWriter(outputFilePath))
                    writer.WriteLine($"{totalSizeKb} KB");

                Console.WriteLine("Folder size calculation completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static long CalculateFolderSize(string folderPath)
        {
            long folderSize = 0;

            var dirInfo = new DirectoryInfo(folderPath);
            foreach (var file in dirInfo.EnumerateFiles("*.*", SearchOption.AllDirectories))
                folderSize += file.Length;

            return folderSize;
        }
    }
}
