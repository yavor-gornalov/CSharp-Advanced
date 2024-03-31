namespace P05_Arithmetics
{
    internal class Program
    {
        static void Main()
        {
            Func<List<double>, List<double>> add = arr => arr.Select(x => x + 1).ToList();
            Func<List<double>, List<double>> multiply = arr => arr.Select(x => x * 2).ToList();
            Func<List<double>, List<double>> subtract = arr => arr.Select(x => x - 1).ToList();
            Action<List<double>> print = arr => Console.WriteLine(string.Join(" ", arr));

            var nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add": { nums = add(nums); break; }
                    case "multiply": { nums = multiply(nums); break; }
                    case "subtract": { nums = subtract(nums); break; }
                    case "print": { print(nums); break; }
                }
            }
        }
    }
}
