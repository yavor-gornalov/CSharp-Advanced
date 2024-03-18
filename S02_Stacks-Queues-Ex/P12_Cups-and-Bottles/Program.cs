namespace P12_Cups_and_Bottles
{
    internal class Program
    {
        static void Main()
        {
            var cups = new LinkedList<int>();
            var bottles = new Stack<int>();

            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .ForEach(x => cups.AddLast(x));

            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .ForEach(x => bottles.Push(x));

            int wastedWater = 0;
            while (bottles.Count > 0 && cups.Count > 0)
            {
                int cupFreeCaoacity = cups.First();
                cups.RemoveFirst();

                int waterQuantity = bottles.Pop();

                if (waterQuantity < cupFreeCaoacity)
                {
                    cups.AddFirst(cupFreeCaoacity - waterQuantity);
                    continue;
                }
                wastedWater += waterQuantity - cupFreeCaoacity;
            }
            if (bottles.Count > 0) Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            if (cups.Count > 0) Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
