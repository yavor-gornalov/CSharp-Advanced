using System.Linq;

namespace P06_Reverse_Exclude
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> filter = (x) => x % divisor != 0;

            Console.WriteLine(string.Join(" ", numbers.FindAll(filter)));

        }
    }
}
