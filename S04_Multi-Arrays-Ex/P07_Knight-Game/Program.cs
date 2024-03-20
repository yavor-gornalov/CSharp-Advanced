namespace P07_Knight_Game
{
    internal class Program
    {
        const char KNIGHT = 'K';
        const char EMPTY = '0';
        static readonly (int, int)[] POSSIBLE_MOVES = { (-2, -1), (-1, -2), (-2, 1), (-1, 2), (1, 2), (2, 1), (2, -1), (1, -2) };

        static int KnightAttacksCounter(char[,] matrix, (int, int) knight)
        {
            int counter = 0;
            foreach (var move in POSSIBLE_MOVES)
            {
                int row = knight.Item1 + move.Item1;
                int col = knight.Item2 + move.Item2;

                if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
                    continue;

                if (matrix[row, col] == KNIGHT)
                    counter++;
            }
            return counter;
        }

        static (int, int) GetMaxAttacker(char[,] board, List<(int, int)> knights)
        {
            int maxAttacksCount = 0;
            (int, int) maxAttacker = (-1, -1);
            foreach (var knight in knights)
            {
                int currentAttacksCount = KnightAttacksCounter(board, knight);
                if (currentAttacksCount > maxAttacksCount)
                {
                    maxAttacksCount = currentAttacksCount;
                    maxAttacker = knight;
                }
            }
            return maxAttacker;
        }

        static void Main()
        {
            int boardSize = int.Parse(Console.ReadLine());
            char[,] board = new char[boardSize, boardSize];
            List<(int, int)> knights = new List<(int, int)>();

            for (int r = 0; r < boardSize; r++)
            {
                char[] line = Console.ReadLine().ToCharArray();
                for (int c = 0; c < boardSize; c++)
                {
                    board[r, c] = line[c];

                    if (line[c] == KNIGHT)
                        knights.Add((r, c));
                }
            }

            int removedKnightsCounter = 0;
            while (true)
            {
                var knightToRemove = GetMaxAttacker(board, knights);
                if (knightToRemove == (-1, -1))
                    break;
                var (row, col) = knightToRemove;
                board[row, col] = EMPTY;
                removedKnightsCounter++;
                knights.Remove((row, col));
            }

            Console.WriteLine(removedKnightsCounter);
        }
    }
}
