namespace P03_Count_Uppercase_Words
{
    internal class Program
    {
        static void Main()
        {
            Predicate<string> checker = n => char.IsUpper(n[0]);
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => checker(x))
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
