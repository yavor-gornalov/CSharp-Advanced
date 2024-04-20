namespace BinarySearch
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var targetElement = int.Parse(Console.ReadLine());

            int idx = BinarySearch.IndexOf(arr, targetElement);

            Console.WriteLine(idx);
        }

        public class BinarySearch
        {
            public static int IndexOf(int[] array, int key)
            {
                int lo = 0;
                int hi = array.Length - 1;
                while (lo <= hi)
                {
                    int mid = lo + (hi - lo) / 2;  
                    if (key < array[mid])
                    {
                        hi = mid - 1;
                    }
                    else if (key > array[mid])
                    {
                        lo = mid + 1;
                    } else
                    {
                        return mid;
                    }
                }
                return -1;
            }
        }
    }
}
