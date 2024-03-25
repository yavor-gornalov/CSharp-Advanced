﻿namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (var reader = new FileStream(inputFilePath, FileMode.Open))
            using (var writer = new FileStream(outputFilePath, FileMode.Create))
            {
                byte[] buffer = new byte[1024];

                int blockCount;
                while ((blockCount = reader.Read(buffer, 0, buffer.Length)) != 0)
                    writer.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
