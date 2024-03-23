using System.Text;

namespace P07_The_V_Logger
{
    internal class Program
    {
        static void Main()
        {
            // vlogger : [followers[], followings[]] 
            var vloggers = new Dictionary<string, (List<string>, List<string>)>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Statistics")
                {
                    //PRINT STATISTICS
                    var sb = new StringBuilder();
                    sb.AppendLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

                    var sortedVloggers = vloggers.OrderByDescending(x => x.Value.Item1.Count).ThenBy(x => x.Value.Item2.Count);

                    var mostFamousVlogger = sortedVloggers.First().Key;

                    int nr = 0;
                    foreach (var (vlogger, vloggerData) in sortedVloggers)
                    {
                        sb.AppendLine($"{++nr}. {vlogger} : {vloggerData.Item1.Count} followers, {vloggerData.Item2.Count} following");
                        if (vlogger == mostFamousVlogger)
                            foreach (var follower in vloggerData.Item1.OrderBy(x => x))
                                sb.AppendLine($"*  {follower}");
                    }
                    Console.Write(sb);
                    break;
                }

                else if (line.Contains("joined"))
                {
                    // JOIN VLOGGER
                    string vlogger = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).First();

                    if (vloggers.ContainsKey(vlogger))
                        continue;

                    vloggers[vlogger] = (new List<string>(), new List<string>());
                }

                else if (line.Contains("followed "))
                {
                    // FOLLOW VLOGGER
                    var tokens = line.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string follower = tokens.First();
                    string vlogger = tokens.Last();

                    if (!vloggers.ContainsKey(follower) || !vloggers.ContainsKey(vlogger))
                        continue;

                    if (vlogger == follower)
                        continue;

                    if (vloggers[vlogger].Item1.Contains(follower))
                        continue;

                    vloggers[vlogger].Item1.Add(follower);
                    vloggers[follower].Item2.Add(vlogger);
                }
            }
        }
    }
}
