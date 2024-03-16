namespace P02_Queue_Operations
{
    internal class Program
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int elementsToEnqueue = tokens[0];
            int elementsToDeque = tokens[1];
            int target = tokens[2];

            var queue = new Queue<int>();
            foreach (int num in Console.ReadLine().Split().Select(int.Parse))
            {
                if (queue.Count < elementsToEnqueue) queue.Enqueue(num);
            }

            for (int i = 0; i < elementsToDeque; i++)
            {
                if (queue.Count > 0) queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (queue.Contains(target)) Console.WriteLine("true");
            else Console.WriteLine(queue.Min());
        }
    }
}
