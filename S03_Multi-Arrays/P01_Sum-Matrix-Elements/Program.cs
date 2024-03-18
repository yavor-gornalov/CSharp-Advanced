using System.Text;

namespace P01_Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var rows = tokens[0];
            var cols = tokens[1];

            int sumOfElements = 0;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                sumOfElements += rowElements.Sum();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }

            var sb = new StringBuilder();
            sb.AppendLine(rows.ToString());
            sb.AppendLine(cols.ToString());
            sb.AppendLine(sumOfElements.ToString());

            Console.WriteLine(sb.ToString());
        }
    }
}
