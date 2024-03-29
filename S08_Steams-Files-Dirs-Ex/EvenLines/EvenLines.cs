namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            var sb = new StringBuilder();
            var reader = new StreamReader(inputFilePath);

            while (!reader.EndOfStream)
            {
                char[] symbolsToReplace = { '-', ',', '.', '!', '?' };

                string line = reader.ReadLine();

                string[] words = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Reverse()
                    .ToArray();

                string newLine = string.Join(" ", words);
                foreach (var symbol in symbolsToReplace)
                {
                    while (newLine.Contains(symbol))
                        newLine = newLine.Replace(symbol, '@');
                }
                sb.AppendLine(newLine);
            }
            return sb.ToString();
        }
    }
}
