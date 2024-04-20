namespace Quicksort
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void QuickSort(int[] nums, int start, int end)
        {
            if (start >= end) return;

            int mid = (start + end) / 2;
            int[] candidates = { nums[start], nums[mid], nums[end] };
            Array.Sort(candidates);
            int pivot = candidates[1];

            int left = start;
            int right = end;

            while (left <= right)
            {
                while (nums[left] < pivot) left++;
                while (nums[right] > pivot) right--;
                if (left <= right)
                {
                    Swap(nums, left, right);
                    left++;
                    right--;
                }
            }

            QuickSort(nums, start, right); // Recursively sort the left part
            QuickSort(nums, left, end); // Recursively sort the right part
        }

        static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
