namespace P10_Radioactive_Bunnies
{
    internal class Program
    {
        const char FREE = '.';
        const char BUNNY = 'B';
        const char PLAYER = 'P';


        private static readonly Dictionary<char, (int, int)> DIRECTIONS =
            new Dictionary<char, (int, int)>()
        {
            {'L', (0, -1)},
            {'R', (0, 1)},
            {'U', (-1, 0)},
            {'D', (1, 0)}
        };

        static void Main()
        {
            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            (int rows, int cols) = (tokens[0], tokens[1]);

            HashSet<(int, int)> bunnies = new HashSet<(int, int)>();

            int row = -1, col = -1;
            char[,] field = new char[rows, cols];
            for (int r = 0; r < rows; r++)
            {
                string line = Console.ReadLine();
                for (int c = 0; c < cols; c++)
                {
                    field[r, c] = line[c];

                    if (field[r, c] == PLAYER)
                        (row, col) = (r, c);

                    if (line[c] == BUNNY)
                        bunnies.Add((r, c));
                }
            }

            Queue<char> commands = new Queue<char>(Console.ReadLine());

            bool endGame = false;
            bool playerWon = false;

            while (!endGame && commands.Count > 0)
            {
                char command = commands.Dequeue();
                if (!DIRECTIONS.ContainsKey(command))
                    continue;

                (int r, int c) = DIRECTIONS[command];
                int nextR = row + r;
                int nextC = col + c;

                if (nextR < 0 || nextR >= rows || nextC < 0 || nextC >= cols)
                {
                    endGame = true;
                    playerWon = true;
                    field[row, col] = FREE;
                }
                else if (field[nextR, nextC] == BUNNY)
                {
                    endGame = true;
                    field[row, col] = FREE;
                    (row, col) = (nextR, nextC);
                }
                else
                {
                    field[row, col] = FREE;
                    field[nextR, nextC] = PLAYER;
                    (row, col) = (nextR, nextC);
                }

                HashSet<(int, int)> bunniesCopy = new HashSet<(int, int)>(bunnies);
                foreach (var bunnyPosition in bunniesCopy)
                {
                    foreach (var direction in DIRECTIONS.Values)
                    {
                        (int dr, int dc) = direction;
                        int row0 = bunnyPosition.Item1;
                        int col0 = bunnyPosition.Item2;
                        int nextRabbitRow = row0 + dr;
                        int nextRabbitCol = col0 + dc;

                        if (nextRabbitRow < 0 || nextRabbitRow >= rows || nextRabbitCol < 0 || nextRabbitCol >= cols)
                        {
                            continue;
                        }

                        if (field[nextRabbitRow, nextRabbitCol] == PLAYER)
                        {
                            playerWon = false;
                            endGame = true;
                        }

                        field[nextRabbitRow, nextRabbitCol] = BUNNY;
                        bunnies.Add((nextRabbitRow, nextRabbitCol));
                    }
                }
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                    Console.Write(field[r, c]);
                Console.WriteLine();
            }

            if (endGame && playerWon)
                Console.WriteLine($"won: {row} {col}");
            else if (endGame && !playerWon)
                Console.WriteLine($"dead: {row} {col}");
        }
    }
}
