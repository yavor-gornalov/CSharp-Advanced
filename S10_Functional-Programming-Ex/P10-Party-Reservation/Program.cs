namespace P10_Party_Reservation
{
    internal class Program
    {
        static void Main()
        {
            var guests = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var filters = new List<string>();

            string line;
            while (true)
            {
                line = Console.ReadLine();

                if (line == "Print")
                {
                    Print(guests, filters);
                    break;
                }

                var tokens = line.Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = tokens[0];
                string filterCondition = tokens[1];
                string filterText = tokens[2];

                var predicate = GetPredicate(filterCondition, filterText);


                string filter = $"{filterCondition}-{filterText}";
                if (command == "Add filter")
                    filters.Add(filter);

                else if (command == "Remove filter")
                    filters.Remove(filter);
            }
        }

        private static void Print(List<string> guests, List<string> filters)
        {
            var filteredGuests = guests;
            foreach (var filter in filters)
            {
                var tokens = filter.Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string filterCondition = tokens[0];
                string filterText = tokens[1];

                var predicator = GetPredicate(filterCondition, filterText);

                filteredGuests = filteredGuests.FindAll(predicator).ToList();

            }

            Console.WriteLine(string.Join(" ", filteredGuests));
        }

        private static Predicate<string>? GetPredicate(string filterCondition, string filterText)
        {
            Predicate<string> predicate = null;
            if (filterCondition == "Starts with")
                predicate = x => !x.StartsWith(filterText);
            if (filterCondition == "Ends with")
                predicate = x => !x.EndsWith(filterText);
            if (filterCondition == "Length")
                predicate = x => x.Length != int.Parse(filterText);
            if (filterCondition == "Contains")
                predicate = x => !x.Contains(filterText);
            return predicate;
        }
    }
}
