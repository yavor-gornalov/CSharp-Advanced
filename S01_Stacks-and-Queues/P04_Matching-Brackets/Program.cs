namespace P04_Matching_Brackets
{
	internal class Program
	{
		static void Main()
		{
			string line = Console.ReadLine();

			var openingBrecetsIdx = new Stack<int>();

			for (int i = 0; i < line.Length; i++)
			{
				char el = line[i];
				if (el == '(')
				{
					openingBrecetsIdx.Push(i);
				}
				else if (el == ')')
				{
					int start = openingBrecetsIdx.Pop();
					int count = i - start + 1;
					Console.WriteLine(line.Substring(start, count));
				}
			}
		}
	}
}
