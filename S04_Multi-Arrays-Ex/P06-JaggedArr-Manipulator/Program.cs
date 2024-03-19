using System.ComponentModel;

namespace P06_Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] jagged = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jagged[i] = Console.ReadLine()
                    .Split()
                    .Select(double.Parse)
                    .ToArray();
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                        jagged[i][j] *= 2;
                    for (int k = 0; k < jagged[i + 1].Length; k++)
                        jagged[i + 1][k] *= 2;
                }
                else
                {
                    for (int j = 0; j < jagged[i].Length; j++)
                        jagged[i][j] /= 2;
                    for (int k = 0; k < jagged[i + 1].Length; k++)
                        jagged[i + 1][k] /= 2;
                }
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End") break;

                var tokens = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = tokens[0];
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                double value = double.Parse(tokens[3]);

                if (row < 0 || col < 0 || row >= rows || col >= jagged[row].Length)
                    continue;

                if (command == "Subtract") value = -value;

                jagged[row][col] += value;
            }

            for (int i = 0; i < rows; i++)
                Console.WriteLine(string.Join(" ", jagged[i]));
        }
    }
}
