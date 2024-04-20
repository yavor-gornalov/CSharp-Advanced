namespace ComparingObjects
{
    internal class StartUp
    {
        static void Main()
        {
            var people = new List<Person>();
            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                var personInfo = line
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var person = new Person(
                        name: personInfo[0],
                        age: int.Parse(personInfo[1]),
                        town: personInfo[2]
                    );

                people.Add(person);
            }

            int personNumber = int.Parse(Console.ReadLine()) - 1;
            int totalPeople = people.Count();
            var tartgetPerson = people[personNumber];
            int countOfMatches = people.Where(p => p.CompareTo(tartgetPerson) == 0).Count();

            if (countOfMatches == 1)
                Console.WriteLine("No matches");
            else
                Console.WriteLine($"{countOfMatches} {totalPeople - countOfMatches} {totalPeople}");
        }
    }
}
