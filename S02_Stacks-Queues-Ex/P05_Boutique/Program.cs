namespace P05_Fashion_Boutique
{
    internal class Program
    {
        static void Main()
        {
            var stack = new Stack<int>();
            foreach (var clothing in Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray())
                stack.Push(clothing);

            var capacity = int.Parse(Console.ReadLine());

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            int boxesUsed = 1;
            int currentBox = capacity;
            while (true)
            {
                if (stack.Count == 0) break;

                if (currentBox < stack.Peek())
                {
                    currentBox = capacity;
                    boxesUsed++;
                    continue;
                }

                currentBox -= stack.Pop();
            }
            Console.WriteLine(boxesUsed);
        }
    }
}
