namespace P01_Reverse_a_String
{
	internal class Program
	{
		static void Main()
		{
			var stack = new Stack<char>();
			var line = Console.ReadLine();

			foreach (char ch in line)
			{
				stack.Push(ch);
			}

			while (stack.Count > 0)
			{
				Console.Write(stack.Pop());
			};
		}
	}
}
