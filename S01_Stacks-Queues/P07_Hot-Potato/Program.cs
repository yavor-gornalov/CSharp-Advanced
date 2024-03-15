namespace P07_Hot_Potato
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var queue = new Queue<string>();
			var children = Console.ReadLine().Split().ToArray();
			var rotations = int.Parse(Console.ReadLine());

			foreach (var child in children)
			{
				queue.Enqueue(child);
			}

			while (queue.Count > 1)
			{
				for (int i = 0; i < rotations - 1; i++)
				{
					queue.Enqueue(queue.Dequeue());
				}
				Console.WriteLine($"Removed {queue.Dequeue()}");
			}
			Console.WriteLine($"Last is {queue.Peek()}");
		}
	}
}
