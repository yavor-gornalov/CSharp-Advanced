namespace P04_Matrix_Shuffling
{
    internal class Program
    {
        static void Main()
        {
            // Reading matrix:
            int[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = tokens[0];
            int cols = tokens[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = line[j];
            }

            // Main logic
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END") break;

                if (!line.StartsWith("swap"))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string[] coordinates = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1)
                    .ToArray();

                if (coordinates.Length != 4)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(coordinates[0]);
                int col1 = int.Parse(coordinates[1]);
                int row2 = int.Parse(coordinates[2]);
                int col2 = int.Parse(coordinates[3]);

                if (row1 < 0 || row1 >= rows ||
                    row2 < 0 || row2 >= rows ||
                    col1 < 0 || col1 >= cols ||
                    col2 < 0 || col2 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                (matrix[row1, col1], matrix[row2, col2]) = (matrix[row2, col2], matrix[row1, col1]);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                        Console.Write(matrix[i, j] + " ");
                    Console.WriteLine();
                }

            };
        }
    }
}
