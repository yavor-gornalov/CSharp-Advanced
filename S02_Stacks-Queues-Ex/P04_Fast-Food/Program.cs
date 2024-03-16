namespace P04_Fast_Food
{
    internal class Program
    {
        static void Main()
        {
            var foodQuantity = int.Parse(Console.ReadLine());
            var orders = new Queue<int>();

            foreach (var order in Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray())
                orders.Enqueue(order);
            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (foodQuantity < orders.Peek())
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
                foodQuantity -= orders.Dequeue();
            }
            Console.WriteLine("Orders complete");
        }
    }
}
