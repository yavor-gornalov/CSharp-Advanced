namespace P06_Supermarket
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Queue<string> queue = new Queue<string>();
			while (true)
			{
				string customer = Console.ReadLine();

				switch (customer)
				{
					case "End":
						{
							Console.WriteLine($"{queue.Count} people remaining.");
							return;
						}
					case "Paid":
						{
							while (queue.Count > 0)
							{
								Console.WriteLine(queue.Dequeue());
							}
							break;
						}
					default:
						{
							queue.Enqueue(customer);
							break;
						}
				}
			}
		}
	}
}
