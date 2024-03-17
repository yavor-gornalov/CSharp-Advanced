namespace P06_Songs_Queue
{
    internal class Program
    {
        static void Main()
        {
            var queue = new Queue<string>();

            Console.ReadLine()
                .Split(", ")
                .ToList()
                .ForEach(song => queue.Enqueue(song));

            while (true)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

                var tokens = Console.ReadLine().Split().ToArray();

                var command = tokens[0];

                switch (command)
                {
                    case "Add":
                        {
                            var song = string.Join(" ", tokens.Skip(1));
                            if (queue.Contains(song))
                            {
                                Console.WriteLine($"{song} is already contained!");
                                continue;
                            }
                            queue.Enqueue(song);
                            break;
                        }
                    case "Show":
                        {
                            Console.WriteLine(string.Join(", ", queue));
                            break;
                        }
                    case "Play":
                        {
                            queue.Dequeue();
                            break;
                        }
                }
            }
        }
    }
}
