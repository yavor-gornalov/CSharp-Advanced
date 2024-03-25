namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            Console.Write("Enter folder path: ");
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var folderContents = new Dictionary<string, List<FileInfo>>();
            var folderInfo = new DirectoryInfo(inputFolderPath);
            foreach (var file in folderInfo.EnumerateFiles("*.*", SearchOption.AllDirectories))
            {
                string ext = file.Extension;
                if (!folderContents.ContainsKey(ext))
                    folderContents[ext] = new List<FileInfo>();
                folderContents[ext].Add(file);
            }

            var sb = new StringBuilder();
            foreach (var (ext, files) in folderContents.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.AppendLine(ext);
                foreach (var file in files.OrderByDescending(x => x.Length))
                    sb.AppendLine($"--{file.Name} - {file.Length / 1024.0:F3}kb");
            }

            return sb.ToString();

        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            var reportPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(reportPath, textContent);
        }
    }
}
