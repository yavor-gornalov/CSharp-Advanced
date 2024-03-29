namespace P01_Sort_Even_Numbers
{
    internal class Program
    {
        static void Main()
        {
            int[] evenNumbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .Where(x => x % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
