namespace P06_Wardrobe
{
    internal class Program
    {
        static void Main()
        {
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split(" -> ");
                string color = tokens[0];
                string[] cloathes = tokens[1].Split(",").ToArray();

                if (!wardrobe.ContainsKey(color))
                    wardrobe[color] = new Dictionary<string, int>();

                foreach (string cloath in cloathes)
                {
                    if (!wardrobe[color].ContainsKey(cloath))
                        wardrobe[color][cloath] = 0;
                    wardrobe[color][cloath]++;
                }
            }

            string[] searchedItem = Console.ReadLine().Split().ToArray();
            string searchedColor = searchedItem[0];
            string searchedCloath = searchedItem[1];

            foreach (var (color, cloathes) in wardrobe)
            {
                Console.WriteLine($"{color} clothes:");
                foreach (var (cloath, count) in cloathes)
                {
                    string currentCloath = $"* {cloath} - {count}";
                    if (color == searchedColor && cloath == searchedCloath)
                        currentCloath += " (found!)";
                    Console.WriteLine(currentCloath);
                }
            }
        }
    }
}
