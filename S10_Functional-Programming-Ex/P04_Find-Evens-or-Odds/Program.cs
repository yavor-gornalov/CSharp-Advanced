namespace P04_Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main()
        {
            var limits = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int start = limits.Min();
            int end = limits.Max();

            string filter = Console.ReadLine();

            var numbers = new List<int>();
            for (int i = start; i <= end; i++)
                numbers.Add(i);

            Predicate<int> predicate = null;
            if (filter == "even")
                predicate = x => x % 2 == 0;

            else if (filter == "odd")
                predicate = x => x % 2 != 0;

            Console.WriteLine(string.Join(" ", numbers.FindAll(predicate)));
        }
    }
}
