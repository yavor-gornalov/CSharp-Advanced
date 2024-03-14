namespace P02_Stack_Sum
{
	internal class Program
	{
		static void Main()
		{
			int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
			var stack = new Stack<int>();

			foreach (var num in input)
			{
				stack.Push(num);
			}

			while (true)
			{
				string[] tokens = Console.ReadLine().ToLower().Split();

				string command = tokens[0];

				switch (command)
				{
					case "end":
						{
							Console.WriteLine($"Sum: {stack.Sum()}");
							return;
						}
					case "add":
						{
							int first = int.Parse(tokens[1]);
							int second = int.Parse(tokens[2]);
							stack.Push(first);
							stack.Push(second);
							break;
						}
					case "remove":
						{
							int count = int.Parse(tokens[1]);
							if (stack.Count >= count)
							{
								for (int i = 0; i < count; i++) stack.Pop();

							}
							break;
						}
				}
			}
		}
	}
}
