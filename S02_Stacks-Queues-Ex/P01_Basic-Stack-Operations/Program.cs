namespace P01_Basic_Stack_Operations
{
    internal class Program
    {
        static void Main()
        {
            int[] tokens = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int elementsToPush = tokens[0];
            int elementsToPop = tokens[1];
            int target = tokens[2];

            var stack = new Stack<int>();
            foreach (int num in Console.ReadLine().Split().Select(int.Parse))
            {
                if (stack.Count < elementsToPush) stack.Push(num);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                if (stack.Count > 0) stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Contains(target)) Console.WriteLine("true");
            else Console.WriteLine(stack.Min());
        }
    }
}
