namespace P02_Squares_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            var tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = tokens[0];
            int cols = tokens[1];

            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                char[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = line[j];
                }

            }

            int equalSqaresCount = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j] &&
                        matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        equalSqaresCount++;
                    }

                }
            }
            Console.WriteLine(equalSqaresCount);
        }
    }
}
