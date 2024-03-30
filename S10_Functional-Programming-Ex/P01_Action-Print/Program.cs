namespace P01_Action_Print
{
    internal class Program
    {
        static void Main()
        {
            Action<string> print =
                message => Console.WriteLine(message);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(x => print(x));
        }
    }
}
