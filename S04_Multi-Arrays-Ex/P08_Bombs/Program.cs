namespace P08_Bombs
{
    internal class Program
    {
        static readonly (int, int)[] DIRECTIONS = {
            (1, -1),  // up-left
            (1, 0),   // up
            (1, 1),   // up-right
            (0, -1),  // left
            (0, 1),   // right
            (-1, -1), // down-left
            (-1, 0),  // down
            (-1, 1),  // down-right
            (0, 0)    // current
        };
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < n; j++)
                    matrix[i, j] = line[j];
            }

            var bombs = new Queue<(int, int)>();
            var bombCoordinates = Console.ReadLine()
                .Split()
                .ToArray();

            foreach (var coodrinates in bombCoordinates)
            {
                var tokens = coodrinates.Split(",");
                int row = int.Parse(tokens[0]);
                int col = int.Parse(tokens[1]);
                bombs.Enqueue((row, col));
            }

            while (bombs.Count > 0)
            {
                var (bombR, bombC) = bombs.Dequeue();
                if (matrix[bombR, bombC] <= 0)
                    continue;

                foreach (var direction in DIRECTIONS)
                {
                    var (r, c) = direction;
                    int row = bombR + r;
                    int col = bombC + c;
                    if (row < 0 || row >= n || col < 0 || col >= n || matrix[row, col] <= 0)
                        continue;
                    matrix[row, col] -= matrix[bombR, bombC];
                }
            }

            int aliveCellsCount = 0;
            int aliveCellsSum = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCellsCount++;
                        aliveCellsSum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
