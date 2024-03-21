using System.Net.Http;
using System.Text;

namespace P05_Cities_by_Continent
{
    internal class Program
    {
        static void Main()
        {
            var continentsCities = new Dictionary<string, Dictionary<string, List<string>>>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                var tokens = Console.ReadLine().Split().ToArray();
                (string continent, string country, string city) = (tokens[0], tokens[1], tokens[2]);

                if (!continentsCities.ContainsKey(continent))
                    continentsCities[continent] = new Dictionary<string, List<string>>();
                if (!continentsCities[continent].ContainsKey(country))
                    continentsCities[continent][country] = new List<string>();
                continentsCities[continent][country].Add(city);
            }

            foreach (var (continentName, coutriesInfo) in continentsCities)
            {
                var sb = new StringBuilder();
                sb.AppendLine(continentName + ":");
                foreach (var (countryName, cites) in coutriesInfo)
                    sb.AppendLine($"\t{countryName} -> {string.Join(", ", cites)}");
                Console.Write(sb.ToString());
            }
        }
    }
}
