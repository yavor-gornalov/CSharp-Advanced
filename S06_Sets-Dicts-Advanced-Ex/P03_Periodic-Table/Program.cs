namespace P03_Periodic_Table
{
    internal class Program
    {
        static void Main()
        {
            var uniqueElements = new SortedSet<string>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList()
                    .ForEach(x => uniqueElements.Add(x));
            }

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
