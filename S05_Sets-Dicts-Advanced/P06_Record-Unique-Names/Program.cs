namespace P06_Record_Unique_Names
{
    internal class Program
    {
        static void Main()
        {
            var uniqueNames = new HashSet<string>();
            int countOfNames = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfNames; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            foreach (string name in uniqueNames)
                Console.WriteLine(name);
        }
    }
}
