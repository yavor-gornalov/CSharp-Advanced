namespace P11_TriFunction
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine(names.First(name => name.Select(letter => (int)letter).Sum() >= N));

        }
    }
}
