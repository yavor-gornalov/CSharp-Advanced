namespace P03_Simple_Calculator
{
	internal class Program
	{
		static void Main()
		{
			string[] tokens = Console.ReadLine().Split().ToArray();

			var numbers = new Stack<int>();
			var operands = new Stack<char>();
			foreach (var ele in tokens.Reverse())
			{
				if ("+-".Contains(ele))
				{
					operands.Push(char.Parse(ele));
				}
				else
				{
					numbers.Push(int.Parse(ele));
				}
			}

			int result = numbers.Pop();
			while (operands.Count > 0)
			{
				char operand = operands.Pop();
				int number = numbers.Pop();
				if (operand == '+') result += number;
				else result -= number;
			}

			Console.WriteLine(result);

		}
	}
}
