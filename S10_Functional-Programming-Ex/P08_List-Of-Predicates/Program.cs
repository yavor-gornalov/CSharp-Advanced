using System.Text;

namespace P08_List_Of_Predicates
{
    internal class Program
    {
        static void Main()
        {
            int endOfSequence = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (int num = 1; num <= endOfSequence; num++)
                numbers.Add(num);

            var dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            var sb = new StringBuilder();
            foreach (int num in numbers)
                if (isDivisible(dividers, num))
                    sb.Append(num + " ");
            Console.WriteLine(sb.ToString().Trim());
        }
        private static bool isDivisible(List<int> dividers, int num)
        {
            foreach (int divider in dividers)
                if (num % divider != 0) return false;
            return true;
        }
    }
}
