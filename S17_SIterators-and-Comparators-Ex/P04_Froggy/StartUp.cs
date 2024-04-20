using Froggy;

namespace Froggy
{
    internal class StartUp
    {
        static void Main()
        {
            var stones = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var lake = new Lake(stones);
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}
