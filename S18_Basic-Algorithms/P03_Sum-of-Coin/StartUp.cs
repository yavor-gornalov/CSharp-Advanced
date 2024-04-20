public class StartUp
{
    public static void Main(string[] args)
    {
        var coins = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderBy(x => x)
            .ToList();
        var target = int.Parse(Console.ReadLine());

        var result = ChooseCoins(coins, target);

        //Console.WriteLine(String.Join(", ", coins));

        if (result == null)
        {
            Console.WriteLine("Error");
        }
        else
        {
            Console.WriteLine($"Number of coins to take: {result.Values.Sum()}");
            foreach (var coin in result)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }

    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        var result = new Dictionary<int, int>();
        for (int i = coins.Count - 1; i >= 0; i--)
        {
            int coin = coins[i];

            if (coin <= targetSum)
            {
                if (!result.ContainsKey(coin))
                    result[coin] = 0;
                result[coin] += targetSum / coin;
                targetSum %= coin;
            }
            if (targetSum == 0)
                return result;
        }
        return null;
    }
}
