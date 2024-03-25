namespace CopyDirectory
{
    using System;
    using System.IO;

    public class CopyDirectory
    {
        static void Main()
        {
            Console.Write("Enter source floder path: ");
            string inputPath = @$"{Console.ReadLine()}";
            Console.Write("Enter destination folder path: ");
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string sourceDir, string destinationDir)
        {
            //Example: https://learn.microsoft.com/en-us/dotnet/standard/io/how-to-copy-directories

            bool recursive = true;

            // Get information about the source directory
            var dir = new DirectoryInfo(sourceDir);

            // Check if the source directory exists
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            // Cache directories before we start copying
            DirectoryInfo[] dirs = dir.GetDirectories();

            // Create the destination directory
            Directory.CreateDirectory(destinationDir);

            // Get the files in the source directory and copy to the destination directory
            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            // If recursive and copying subdirectories, recursively call this method
            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    CopyAllFiles(subDir.FullName, newDestinationDir);
                }
            }

            Console.WriteLine($"Directory{dir.Name} has been copied to destination:\n{destinationDir}");
        }
    }
}
