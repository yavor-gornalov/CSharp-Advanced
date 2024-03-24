namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                int counter = 0;
                string line = reader.ReadLine();
                using (var writer = new StreamWriter(outputFilePath))
                {
                    while (line != null)
                    {
                        writer.WriteLine($"{++counter}. {line}");
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
