namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            var content = new List<string>();

            var lines = File.ReadAllLines(inputFilePath);

            int lineNumber = 0;
            foreach (var line in lines)
            {
                int symbolsCount = line.Count(char.IsLetter);
                //int symbolsCount = Regex.Matches(line, @"[A-Za-z]").Count;
                int punctuationsCount = line.Count(char.IsPunctuation);
                //int punctuationsCount = Regex.Matches(line, @"[\p{P}\d]").Count;
                content.Add($"Line {++lineNumber}: {line} ({symbolsCount})({punctuationsCount})");

            }

            File.WriteAllLines(outputFilePath, content);
        }
    }
}
