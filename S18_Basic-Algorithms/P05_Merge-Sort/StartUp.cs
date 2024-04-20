
namespace MergeSort
{
    internal class StartUp
    {
        static void Main()
        {
            var arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var sortedArr = MergeSort(arr);
            Console.WriteLine(string.Join(" ", sortedArr));
        }

        static List<int> MergeArrays(List<int> left, List<int> right)
        {
            List<int> sortedArr = new List<int>();
            int leftIdx = 0, rightIdx = 0;
            while (leftIdx < left.Count && rightIdx < right.Count)
            {
                if (left[leftIdx] < right[rightIdx])
                {
                    sortedArr.Add(left[leftIdx]);
                    leftIdx++;
                }
                else
                {
                    sortedArr.Add(right[rightIdx]);
                    rightIdx++;
                }
            }
            while (leftIdx < left.Count)
            {
                sortedArr.Add(left[leftIdx]);
                leftIdx++;
            }
            while (rightIdx < right.Count)
            {
                sortedArr.Add(right[rightIdx]);
                rightIdx++;
            }
            return sortedArr;
        }

        static List<int> MergeSort(int[] nums)
        {
            if (nums.Length == 1)
            {
                return new List<int>(nums);
            }
            int midIdx = nums.Length / 2;
            var left = new List<int>(nums[0..midIdx]);
            var right = new List<int>(nums[midIdx..]);

            return MergeArrays(MergeSort(left.ToArray()), MergeSort(right.ToArray()));
        }
    }
}
