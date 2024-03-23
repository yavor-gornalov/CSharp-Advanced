namespace P05_Count_Symbols
{
    internal class Program
    {
        static void Main()
        {
            var symbolsCount = new Dictionary<char, int>();

            string line = Console.ReadLine();

            foreach (var symbol in line)
            {
                if (!symbolsCount.ContainsKey(symbol))
                    symbolsCount[symbol] = 0;
                symbolsCount[symbol]++;
            }

            foreach (var (symbol, count) in symbolsCount.OrderBy(x => x.Key))
                Console.WriteLine($"{symbol}: {count} time/s");
        }
    }
}
