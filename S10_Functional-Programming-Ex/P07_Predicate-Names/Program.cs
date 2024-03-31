namespace P07_Predicate_Names
{
    internal class Program
    {
        static void Main()
        {
            int nameMaxLength = int.Parse(Console.ReadLine());

            Predicate<string> filter = x => x.Length <= nameMaxLength;
            Action<string> print = x => Console.WriteLine(x);

            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            names.FindAll(filter)
                .ToList()
                .ForEach(x => print(x));
        }
    }
}
