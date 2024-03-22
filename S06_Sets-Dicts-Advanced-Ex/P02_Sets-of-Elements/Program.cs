namespace P02_Sets_of_Elements
{
    internal class Program
    {
        static void Main()
        {
            var tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstLength = tokens[0];
            int secondLength = tokens[1];

            var firstSet = new HashSet<string>(firstLength);
            var secondSet = new HashSet<string>(secondLength);

            for (int i = 0; i < firstLength; i++)
                firstSet.Add(Console.ReadLine());

            for (int i = 0; i < secondLength; i++)
                secondSet.Add(Console.ReadLine());

            var commonElements = firstSet.Intersect(secondSet);

            Console.WriteLine(string.Join(" ", commonElements));
        }
    }
}
