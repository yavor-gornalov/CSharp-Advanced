namespace P02_Sum_Numbers
{
    internal class Program
    {
        static void Main()
        {
            Func<string, int> parser = num => int.Parse(num);

            var numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToList();

            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        }
    }
}
