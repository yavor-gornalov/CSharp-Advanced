namespace P01_Unique_Usernames
{
    internal class Program
    {
        static void Main()
        {
            var uniqueUsernames = new HashSet<string>();
            int numberOfUsernames = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfUsernames; i++)
            {
                uniqueUsernames.Add(Console.ReadLine());
            }

            foreach (var username in uniqueUsernames)
                Console.WriteLine(username);
        }
    }
}
