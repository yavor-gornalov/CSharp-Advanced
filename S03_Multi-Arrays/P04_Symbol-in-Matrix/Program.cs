namespace P04_Symbol_in_Matrix
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            string[] matrix = new string[size];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine();
            }

            char target = char.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                if (matrix[i].Contains(target))
                {
                    Console.WriteLine($"({i}, {matrix[i].IndexOf(target)})");
                    return;
                }
            }
            Console.WriteLine($"{target} does not occur in the matrix");
        }
    }
}
