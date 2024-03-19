namespace P05_Snake_Moves
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

            var text = new Queue<char>();
            Console.ReadLine()
                .ToList()
                .ForEach(x => text.Enqueue(x));

            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = text.Peek();
                        text.Enqueue(text.Dequeue());
                    }
                else
                {
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        matrix[i, j] = text.Peek();
                        text.Enqueue(text.Dequeue());
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(matrix[i, j]);
                Console.WriteLine();
            }
        }
    }
}
