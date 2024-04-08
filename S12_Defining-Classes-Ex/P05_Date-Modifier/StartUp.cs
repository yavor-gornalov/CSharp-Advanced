using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class StartUp
    {
        static void Main()
        {
            var firstDateTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondDateTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            var firstDate = new DateTime(firstDateTokens[0], firstDateTokens[1], firstDateTokens[2]);
            var secondDate = new DateTime(secondDateTokens[0], secondDateTokens[1], secondDateTokens[2]);

            var dateModifier = new DateModifier(firstDate, secondDate);
            var differenceInDays = Math.Abs(dateModifier.GetDateDifference());


            Console.WriteLine(differenceInDays);


        }
    }
}
