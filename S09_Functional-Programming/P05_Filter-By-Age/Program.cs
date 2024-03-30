using System;

namespace P05_Filter_By_Age
{
    internal class Program
    {
        static void Main()
        {
            List<Person> people = ReadPeople();

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(condition, age);
            Action<Person> printer = CreatePrinter(format);
            PrintFilteredPeople(people, filter, printer);

        }

        private static List<Person> ReadPeople()
        {
            int count = int.Parse(Console.ReadLine());
            var people = new List<Person>(count);

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                people.Add(new Person(name, age));
            }

            return people;
        }

        public static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            switch (condition)
            {
                case "younger": return x => x.Age < ageThreshold;
                case "older": return x => x.Age >= ageThreshold;
                default: throw new ArgumentException(condition);
            }
        }

        public static Action<Person> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine($"{person.Name}");
                case "age":
                    return person => Console.WriteLine($"{person.Age}");
                case "name age":
                    return person => Console.WriteLine($"{person.Name} - {person.Age}");
                default: throw new ArgumentException(format);
            }

        }
        public static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            foreach (Person person in people.Where(x => filter(x)))
                printer(person);
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}

