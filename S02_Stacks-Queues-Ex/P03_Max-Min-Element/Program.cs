using System.Text;

namespace P03_Max_Min_Element
{
    internal class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < N; i++)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = tokens[0];
                switch (command)
                {
                    case 1:
                        {
                            int num = tokens[1];
                            stack.Push(num);
                            break;
                        }
                    case 2:
                        {
                            if (stack.Count > 0) stack.Pop();
                            break;
                        }
                    case 3:
                        {
                            if (stack.Count > 0) Console.WriteLine(stack.Max());
                            break;
                        }
                    case 4:
                        {
                            if (stack.Count > 0) Console.WriteLine(stack.Min());
                            break;
                        }
                }
            }
            if (stack.Count > 0) Console.WriteLine(string.Join(", ", stack));
        }
    }
}
