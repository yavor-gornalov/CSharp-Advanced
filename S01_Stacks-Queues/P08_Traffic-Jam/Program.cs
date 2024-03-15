namespace P08_Traffic_Jam
{
	internal class Program
	{
		static void Main()
		{
			var queue = new Queue<string>();
			int crossroadsCapacity = int.Parse(Console.ReadLine());
			int traficCounter = 0;
			while (true)
			{
				string line = Console.ReadLine();
				if (line == "end")
				{
					Console.WriteLine($"{traficCounter} cars passed the crossroads.");
					return;
				}
				else if (line == "green")
				{
					for (int i = 0; i < crossroadsCapacity; i++)
					{
						if (queue.Count == 0) break;
						Console.WriteLine($"{queue.Dequeue()} passed!");
						traficCounter++;
					}
				}
				else
				{
					queue.Enqueue(line);
				}
			}
		}
	}
}
