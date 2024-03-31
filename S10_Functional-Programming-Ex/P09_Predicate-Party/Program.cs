using System;
using System.Diagnostics.Metrics;

namespace P09_Predicate_Party
{
    internal class Program
    {
        static void Main()
        {
            var guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string line;
            while ((line = Console.ReadLine()) != "Party!")
            {
                var tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];
                string subCommand = tokens[1];
                string filter = tokens[2];

                var predicate = GetPredicate(subCommand, filter);

                foreach (var guest in guests.FindAll(predicate))
                {
                    if (command == "Remove")
                        guests.Remove(guest);
                    else if (command == "Double")
                        guests.Insert(guests.IndexOf(guest), guest);
                }
            }

            if (guests.Count > 0)
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            else
                Console.WriteLine("Nobody is going to the party!");

        }

        private static Predicate<string>? GetPredicate(string subCommand, string filter)
        {
            Predicate<string> predicate = null;
            if (subCommand == "StartsWith")
                predicate = x => x.StartsWith(filter);
            if (subCommand == "EndsWith")
                predicate = x => x.EndsWith(filter);
            if (subCommand == "Length")
                predicate = x => x.Length == int.Parse(filter);
            return predicate;
        }
    }
}
