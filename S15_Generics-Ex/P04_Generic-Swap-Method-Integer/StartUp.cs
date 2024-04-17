namespace GenericSwapMethodInteger
{
    internal class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var listOfBoxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                var box = new Box<int>(value);
                listOfBoxes.Add(box);
            }
        
            var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int first = tokens[0];
            int second = tokens[1];

            swapCommand(listOfBoxes, first, second);

            listOfBoxes.ForEach(b => Console.WriteLine(b));
        }

        public static void swapCommand<T>(List<T> arr, int firstIdx, int secondIdx) { 
            var temp = arr[firstIdx];
            arr[firstIdx] = arr[secondIdx];
            arr[secondIdx] = temp;
        }
    }
}
