namespace P05_Square_With_Max_Sum
{
    internal class Program
    {
        static void Main()
        {
            var tokens = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            var rows = tokens[0];
            var cols = tokens[1];

            int[,] matrix = new int[rows, cols];


            for (int i = 0; i < rows; i++)
            {
                var rowElements = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }

            int maxSum = 0;
            int[,] maxSquare = new int[2, 2];
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    var currentSqare = new int[2, 2]
                    {
                        {matrix[i, j], matrix[i, j+1] },
                        {matrix[i+1, j], matrix[i+1, j+1] }
                    };

                    int currentSum = 0;
                    for (int k = 0; k < 2; k++)
                    {
                        for (int l = 0; l < 2; l++)
                        {
                            currentSum += currentSqare[k, l];
                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSquare = currentSqare;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(maxSquare[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
