namespace P03_Maximal_Sum
{
    internal class Program
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = tokens[0];
            int cols = tokens[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = line[j];
            }

            long bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    int[,] currentSquare = new int[3, 3];
                    for (int k = 0; k < 3; k++)
                        for (int l = 0; l < 3; l++)
                            currentSquare[k, l] = matrix[i + k, j + l];
                    long currentSum = 0;
                    foreach (var el in currentSquare)
                        currentSum += el;

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = i;
                        bestCol = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {bestSum}");
            for (int i = bestRow; i < bestRow + 3; i++)
            {
                for (int j = bestCol; j < bestCol + 3; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
