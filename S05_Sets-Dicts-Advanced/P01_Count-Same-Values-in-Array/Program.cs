namespace P01_Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main()
        {
            var numberOfOccurrences = new Dictionary<double, int>();
            Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList()
                .ForEach(x =>
                {
                    if (!numberOfOccurrences.ContainsKey(x))
                        numberOfOccurrences[x] = 0;
                    numberOfOccurrences[x]++;
                });

            foreach (var (number, occurences) in numberOfOccurrences)
                Console.WriteLine($"{number} - {occurences} times");
        }
    }
}
