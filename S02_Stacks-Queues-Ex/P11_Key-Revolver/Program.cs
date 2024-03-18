namespace P11_Key_Revolver
{
    internal class Program
    {
        static void Main()
        {
            var bullets = new Stack<int>();
            var locks = new Queue<int>();

            var bulletPrice = int.Parse(Console.ReadLine());
            var barrelSize = int.Parse(Console.ReadLine());
            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .ForEach(x => bullets.Push(x));

            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList()
                .ForEach(x => locks.Enqueue(x));
            var intelligence = int.Parse(Console.ReadLine());


            int moneyEarned = intelligence;
            int totalShoots = 0;
            while (true)
            {
                var locksLeft = locks.Count;
                var bulletsLeft = bullets.Count;

                if (locksLeft == 0)
                {
                    Console.WriteLine($"{bulletsLeft} bullets left. Earned ${moneyEarned}");
                    break;
                }

                if (bulletsLeft == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
                    break;
                }

                int currentBullet = bullets.Pop();
                var currentLock = locks.Peek();
                bulletsLeft--;
                totalShoots++;
                moneyEarned -= bulletPrice;

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                    locksLeft--;
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (totalShoots % barrelSize == 0 && bulletsLeft > 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
        }
    }
}
