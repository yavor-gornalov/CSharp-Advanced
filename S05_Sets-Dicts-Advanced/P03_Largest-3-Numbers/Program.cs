namespace P03_Largest_3_Numbers
{
    internal class Program
    {
        static void Main()
        {
            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
    }
}
