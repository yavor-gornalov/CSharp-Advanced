using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var family = new Family();


            for (int i = 0; i < N; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                var newMember = new Person(name, age);
                family.AddMember(newMember);
            }

            var memberOver30 = family.GetMembersOverAge(30);

            foreach (var member in memberOver30.OrderBy(x => x.Name))
                Console.WriteLine($"{member.Name} - {member.Age}");

        }
    }
}
