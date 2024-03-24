using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var wordsByCount = new Dictionary<string, int>();

            var wordsReader = new StreamReader(wordsFilePath);
            using (wordsReader)
            {
                string line = wordsReader.ReadLine();
                while (line != null)
                {
                    foreach (var word in line.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray())
                        if (!wordsByCount.ContainsKey(word))
                            wordsByCount[word] = 0;
                    line = wordsReader.ReadLine();
                }
            }

            var textReader = new StreamReader(textFilePath);
            using (textReader)
            {
                char[] separators = { ',', ' ', '.', '!', '?', '-' };
                string line = textReader.ReadLine();
                while (line != null)
                {
                    foreach (var word in line.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray())
                        if (wordsByCount.ContainsKey(word))
                            wordsByCount[word]++;
                    
                    line = textReader.ReadLine();
                }

            }

            using (var writer = new StreamWriter(outputFilePath))
            {
                foreach (var (word, count) in wordsByCount.OrderByDescending(x => x.Value))
                    writer.WriteLine($"{word} - {count}");
            }
        }
    }
}
