namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            try
            {
                // Read bytes to extract from the text file
                HashSet<byte> bytesToExtract = new HashSet<byte>();
                foreach (string line in File.ReadLines(bytesFilePath))
                {
                    if (byte.TryParse(line, out byte byteValue))
                    {
                        bytesToExtract.Add(byteValue);
                    }
                }

                // Read all bytes from the binary file
                byte[] allBytes = File.ReadAllBytes(binaryFilePath);

                // Write matching bytes to the output file
                using (FileStream outputFileStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    foreach (byte byteRead in allBytes)
                    {
                        if (bytesToExtract.Contains(byteRead))
                            outputFileStream.WriteByte(byteRead);
                    }
                }

                Console.WriteLine("Extraction completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}