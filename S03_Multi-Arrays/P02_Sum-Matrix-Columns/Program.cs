namespace P02_Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            var rows = tokens[0];
            var cols = tokens[1];

            int[] colSums = new int[cols];
            for (int i = 0; i < rows; i++)
            {
                var rowElements = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    colSums[j] += rowElements[j];
                }
            }

            foreach (var sum in colSums)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
