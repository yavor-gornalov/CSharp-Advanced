





using System.Drawing;
using System.Text;

namespace P10_ForceBook
{
    internal class Program
    {
        static void Main()
        {
            // { forceSide: [forceUser1, ..., forceUserN] }
            var forceSides = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    PrintForceSides(forceSides);
                    break;
                }

                if (line.Contains(" | "))
                {
                    var tokens = line.Split(" | ").ToArray();
                    string side = tokens[0];
                    string user = tokens[1];

                    if (!isUserExists(forceSides, user))
                        AddUser(forceSides, side, user, printMessage: false);

                }
                else if (line.Contains(" -> "))
                {
                    var tokens = line.Split(" -> ").ToArray();
                    string user = tokens[0];
                    string side = tokens[1];
                    ChangeUserSide(forceSides, side, user);

                }
            }
        }

        private static void PrintForceSides(Dictionary<string, List<string>> forceSides)
        {
            var sb = new StringBuilder();
            foreach (var (side, users) in forceSides.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.AppendLine($"Side: {side}, Members: {users.Count}");
                foreach (var user in users.OrderBy(x => x))
                    sb.AppendLine($"! {user}");

            }
            Console.Write(sb.ToString());
        }

        private static void ChangeUserSide(Dictionary<string, List<string>> forceSides, string newSide, string user)
        {
            if (!isUserExists(forceSides, user))
            {
                AddUser(forceSides, newSide, user, printMessage: true);
                return;
            }

            foreach (var (side, users) in forceSides)
                if (users.Contains(user))
                {
                    forceSides[side].Remove(user);
                    if (forceSides[side].Count == 0)
                        forceSides.Remove(side);
                }
            AddUser(forceSides, newSide, user, printMessage: false);
            Console.WriteLine($"{user} joins the {newSide} side!");


        }

        private static void AddUser(Dictionary<string, List<string>> forceSides, string side, string user, bool printMessage)
        {
            if (!forceSides.ContainsKey(side))
                forceSides[side] = new List<string>();
            forceSides[side].Add(user);

            if (printMessage)
                Console.WriteLine($"{user} joins the {side} side!");
        }

        private static bool isUserExists(Dictionary<string, List<string>> forceSides, string user)
        {
            foreach (var (forceSide, sideUsers) in forceSides)
                foreach (var forceUser in sideUsers)
                    if (forceUser == user)
                        return true;
            return false;

        }
    }
}
