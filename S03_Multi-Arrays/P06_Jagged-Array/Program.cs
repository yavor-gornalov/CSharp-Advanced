
namespace P06_Jagged_Array_Modification
{
    internal class Program
    {
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                jagged[i] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            while (true)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = tokens[0];

                if (command == "END")
                {
                    PrintJagged(jagged, rows);
                    break;
                }

                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                switch (command)
                {
                    case "Add":
                        {
                            if (coordinatesValid(jagged, row, col))
                            {
                                jagged[row][col] += value;
                            }
                            break;
                        }
                    case "Subtract":
                        {
                            if (coordinatesValid(jagged, row, col))
                            {
                                jagged[row][col] -= value;
                            }
                            break;
                        }
                }
            }

        }

        private static void PrintJagged(int[][] jagged, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool coordinatesValid(int[][] jagged, int row, int col)
        {
            if (row < 0 || row >= jagged.Length || col < 0 || col >= jagged[row].Length)
            {
                Console.WriteLine("Invalid coordinates");
                return false;
            }
            return true;
        }
    }
}
