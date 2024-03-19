namespace P01_Diagonal_Difference
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int primaryDiag = 0;
            int secondaryDiag = 0;
            for (int row = 0; row < size; row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = line[col];

                    if (row == col) primaryDiag += matrix[row, col];
                    if (col == size - row - 1) secondaryDiag += matrix[row, col];
                }
            }
            Console.WriteLine(Math.Abs(primaryDiag - secondaryDiag));
        }
    }
}
