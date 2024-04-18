namespace Threeuple
{
    internal class Startup
    {
        static void Main()
        {
            var personTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var person = new Threeuple<string, string, string>($"{personTokens[0]} {personTokens[1]}", personTokens[2], String.Join(" ", personTokens.Skip(3).ToList()));
            Console.WriteLine(person);

            var beerTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var beer = new Threeuple<string, int, bool>(beerTokens[0], int.Parse(beerTokens[1]), beerTokens[2] == "drunk");
            Console.WriteLine(beer);

            var accountTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var account = new Threeuple<string, double, string>(accountTokens[0], double.Parse(accountTokens[1]), accountTokens[2]);
            Console.WriteLine(account);
        }
    }
}
