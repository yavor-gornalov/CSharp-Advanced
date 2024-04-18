namespace CustomTuple
{
    internal class StartUp
    {
        static void Main()
        {
            var personTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var person = new CustomTuple<string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2]);
            Console.WriteLine(person);

            var beerTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var beer = new CustomTuple<string, int>(beerTokens[0], int.Parse(beerTokens[1]));
            Console.WriteLine(beer);

            var numbersTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var numbers = new CustomTuple<int, double>(int.Parse(numbersTokens[0]), double.Parse(numbersTokens[1]));
            Console.WriteLine(numbers);
        }
    }
}
