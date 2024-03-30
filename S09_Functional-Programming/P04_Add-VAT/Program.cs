namespace P04_Add_VAT
{
    internal class Program
    {
        static void Main()
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.20)
                .ToList()
                .ForEach(x => Console.WriteLine(x.ToString("f2")));
        }
    }
}
