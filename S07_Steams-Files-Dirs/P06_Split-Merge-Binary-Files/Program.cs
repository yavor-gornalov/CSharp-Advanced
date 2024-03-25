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
            try
            {
                byte[] fileBytes = File.ReadAllBytes(sourceFilePath);

                int fileSize = fileBytes.Length;
                int partOneSize = fileSize / 2;
                int partTwoSize = fileSize - partOneSize;

                // Write the first part
                using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Create))
                    partOneStream.Write(fileBytes, 0, partOneSize);

                // Write the second part
                using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Create))
                    partTwoStream.Write(fileBytes, partOneSize, partTwoSize);

                Console.WriteLine("Splitting completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            try
            {
                byte[] partOneBytes = File.ReadAllBytes(partOneFilePath);
                byte[] partTwoBytes = File.ReadAllBytes(partTwoFilePath);

                using (FileStream joinedFileStream = new FileStream(joinedFilePath, FileMode.Create))
                {
                    joinedFileStream.Write(partOneBytes, 0, partOneBytes.Length);
                    joinedFileStream.Write(partTwoBytes, 0, partTwoBytes.Length);
                }

                Console.WriteLine("Merging completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
