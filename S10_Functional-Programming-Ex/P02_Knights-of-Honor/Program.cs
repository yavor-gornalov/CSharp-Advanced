namespace P02_Knights_of_Honor
{
    internal class Program
    {
        static void Main()
        {
            Action<string> print =
                 name => Console.WriteLine($"Sir {name}");

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(x => print(x));
        }
    }
}
