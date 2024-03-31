namespace P03_Custom_Min
{
    internal class Program
    {
        static void Main()
        {
            Func<int[], int> customMin =
                nums =>
                {
                    int min = int.MaxValue;
                    foreach (int n in nums)
                        if (n < min)
                            min = n;
                    return min;
                };

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(customMin(numbers));
        }
    }
}
