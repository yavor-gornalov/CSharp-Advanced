namespace RecursiveArraySum
{
    internal class RecursiveArraySum
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Sum(arr));
        }

        public static long Sum(int[] arr, int idx = 0)
        {
            if (arr.Length == 0)
                return -1;
            if (idx == arr.Length - 1)
                return arr[idx];

            return arr[idx] + Sum(arr, idx + 1);
        }
    }
}
