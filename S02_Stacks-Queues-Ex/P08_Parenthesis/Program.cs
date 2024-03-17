namespace P08_Balanced_Parenthesis
{
    internal class Program
    {
        static void Main()
        {
            string[] solutions = { "{}", "[]", "()" };
            string expression = Console.ReadLine();

            var openingBrackets = new Stack<char>();

            foreach (var bracket in expression)
            {
                if ("{[(".Contains(bracket))
                {
                    openingBrackets.Push(bracket);
                }
                else if (")]}".Contains(bracket))
                {
                    if (openingBrackets.Count > 0)
                    {
                        var openingBracket = openingBrackets.Pop();
                        if (solutions.Contains(openingBracket.ToString() + bracket.ToString()))
                        {
                            continue;
                        }
                    }
                    Console.WriteLine("NO");
                    return;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
