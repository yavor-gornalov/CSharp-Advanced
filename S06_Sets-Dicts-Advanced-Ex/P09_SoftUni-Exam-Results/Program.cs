using System.Text;

namespace P09_SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main()
        {
            var userSubmissions = new Dictionary<string, int>();
            var languageSubmissionsCount = new Dictionary<string, int>();
            var bannedUsers = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "exam finished")
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("Results:");
                    foreach (var (user, userPoints) in userSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                        if (!bannedUsers.Contains(user))
                            sb.AppendLine($"{user} | {userPoints}");

                    sb.AppendLine("Submissions:");
                    foreach (var (languageName, count) in languageSubmissionsCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                        sb.AppendLine($"{languageName} - {count}");

                    Console.Write(sb.ToString());

                    break;
                }

                string[] tokens = line.Split("-");
                string username = tokens[0];
                string language = tokens[1];

                if (language == "banned")
                {
                    bannedUsers.Add(username);
                    continue;
                }

                int points = int.Parse(tokens[2]);

                if (!userSubmissions.ContainsKey(username))
                    userSubmissions[username] = 0;
                userSubmissions[username] = Math.Max(userSubmissions[username], points);

                if (!languageSubmissionsCount.ContainsKey(language))
                    languageSubmissionsCount[language] = 0;
                languageSubmissionsCount[language]++;
            }


        }
    }
}
