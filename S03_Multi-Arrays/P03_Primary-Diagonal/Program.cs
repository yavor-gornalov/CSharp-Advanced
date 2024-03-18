namespace P03_Primary_Diagonal
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int diagonalSum = 0;
            for (int i = 0; i < size; i++)
            {
                var rowElements = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                diagonalSum += rowElements[i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
