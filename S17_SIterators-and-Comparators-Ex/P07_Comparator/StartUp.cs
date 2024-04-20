namespace CustomComparator
{
    internal class StartUp
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Array.Sort(arr, CustomComparator);

            Console.WriteLine(String.Join(" ", arr));
        }

        public static int CustomComparator(int x, int y)
        {
            if (isEven(x) && isEven(y) || !isEven(x) && !isEven(y))
                return x.CompareTo(y);
            if (isEven(x))
                return -1;
            return 1;
        }

        private static bool isEven(int x) => x % 2 == 0;
    }
}
