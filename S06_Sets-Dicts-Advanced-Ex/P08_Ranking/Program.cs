using System.Text;

namespace P08_Ranking
{
    internal class Program
    {
        static void Main()
        {
            var contestsByPass = new Dictionary<string, string>();
            var usersByPoints = new Dictionary<string, int>();
            var usersByContests = new Dictionary<string, Dictionary<string, int>>();

            // Reading contests with passwords
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of contests")
                    break;

                string[] tokens = command.Split(":");
                string contest = tokens[0];
                string password = tokens[1];
                if (!contestsByPass.ContainsKey(contest))
                    contestsByPass[contest] = string.Empty;
                contestsByPass[contest] = password;
            }

            // Reading submissions
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of submissions")
                    break;

                string[] tokens = command.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!contestsByPass.ContainsKey(contest) || password != contestsByPass[contest])
                    continue;

                if (!usersByContests.ContainsKey(username))
                    usersByContests[username] = new Dictionary<string, int>();

                if (!usersByContests[username].ContainsKey(contest))
                    usersByContests[username][contest] = points;
                else
                    usersByContests[username][contest] = Math.Max(usersByContests[username][contest], points);
            }

            // Calculating total points for each user
            foreach (var (user, contestData) in usersByContests)
                usersByPoints[user] = contestData.Values.Sum();

            var sb = new StringBuilder();

            // Finding the user with the highest total points
            string topUser = usersByPoints.OrderByDescending(x => x.Value).First().Key;
            sb.AppendLine($"Best candidate is {topUser} with total {usersByPoints[topUser]} points.");
            sb.AppendLine("Ranking:");

            // Sorting users by name
            foreach (var (user, userContests) in usersByContests.OrderBy(x => x.Key))
            {
                sb.AppendLine(user);
                foreach (var (contest, points) in userContests.OrderByDescending(x => x.Value))
                    sb.AppendLine($"#  {contest} -> {points}");
            }

            Console.Write(sb.ToString());
        }
    }
}
