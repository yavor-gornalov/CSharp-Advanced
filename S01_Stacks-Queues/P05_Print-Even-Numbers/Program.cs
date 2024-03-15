namespace P05_Print_Even_Numbers
{
	internal class Program
	{
		static void Main()
		{
			Queue<int> queue = new Queue<int>();

			int[] numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x % 2 == 0).ToArray();

			foreach (int number in numbers)
			{
				queue.Enqueue(number);
			}

			Console.WriteLine(string.Join(", ", queue.ToArray()));
		}
	}
}
