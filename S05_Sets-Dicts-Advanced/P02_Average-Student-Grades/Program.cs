namespace P02_Average_Student_Grades
{
    internal class Program
    {
        static void Main()
        {
            var studentGrades = new Dictionary<string, List<decimal>>();
            int numberOfGrades = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfGrades; i++)
            {
                var line = Console.ReadLine().Split().ToArray();
                string student = line[0];
                decimal grade = decimal.Parse(line[1]);

                if (!studentGrades.ContainsKey(student))
                    studentGrades[student] = new List<decimal>();
                studentGrades[student].Add(grade);
            }
            foreach (var (student, grades) in studentGrades)
            {
                Console.WriteLine($"{student} -> {string.Join(" ", grades.Select(x => x.ToString("f2")))} (avg: {grades.Average():f2})");
            }
        }
    }
}
