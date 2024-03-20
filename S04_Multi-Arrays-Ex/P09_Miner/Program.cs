namespace P09_Miner
{
    internal class Program
    {
        private static Dictionary<string, (int, int)> DIRECTIONS =
            new Dictionary<string, (int, int)>
            {
                {"up", (-1, 0)},
                {"down", (1, 0)},
                {"left", (0, -1)},
                {"right", (0, 1)}
            };
        const char EMPTY = '*';
        const char END = 'e';
        const char COAL = 'c';
        const char MINER = 's';

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            var commands = new Queue<string>(Console.ReadLine().Split());

            char[,] field = new char[size, size];

            int coalLeft = 0;
            int row = -1, col = -1;

            for (int r = 0; r < size; r++)
            {
                char[] line = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int c = 0; c < size; c++)
                {
                    field[r, c] = line[c];

                    if (line[c] == MINER)
                        (row, col) = (r, c);

                    if (line[c] == COAL)
                        coalLeft++;
                }
            }

            bool endReached = false;
            while (commands.Count > 0 && coalLeft > 0 && !endReached)
            {
                string command = commands.Dequeue();
                if (!DIRECTIONS.ContainsKey(command))
                    continue;

                (int r, int c) = DIRECTIONS[command];
                int nextR = row + r;
                int nextC = col + c;

                if (nextR < 0 || nextR >= size || nextC < 0 || nextC >= size)
                    continue;

                if (field[nextR, nextC] == COAL)
                    coalLeft--;
                else if (field[nextR, nextC] == END)
                    endReached = true;

                field[row, col] = EMPTY;
                field[nextR, nextC] = MINER;
                (row, col) = (nextR, nextC);
            }

            if (endReached)
                Console.WriteLine($"Game over! ({row}, {col})");
            else if (coalLeft > 0)
                Console.WriteLine($"{coalLeft} coals left. ({row}, {col})");
            else
                Console.WriteLine($"You collected all coals! ({row}, {col})");
        }
    }
}
