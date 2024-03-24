namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            var firstReader = new StreamReader(firstInputFilePath);
            var secondReader = new StreamReader(secondInputFilePath);

            var firstFileContent = GetFileContent(firstReader);
            var secondFileContent = GetFileContent(secondReader);

            using (var outputWriter = new StreamWriter(outputFilePath))
            {
                while (firstFileContent.Count > 0 || secondFileContent.Count > 0)
                {
                    if (firstFileContent.Count > 0)
                        outputWriter.WriteLine(firstFileContent.Dequeue());

                    if (secondFileContent.Count > 0)
                        outputWriter.WriteLine(secondFileContent.Dequeue());
                }
            }
        }

        private static Queue<string> GetFileContent(StreamReader reader)
        {
            var fileContent = new Queue<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    fileContent.Enqueue(line);
                    line = reader.ReadLine();
                }
            }
            return fileContent;
        }
    }
}
