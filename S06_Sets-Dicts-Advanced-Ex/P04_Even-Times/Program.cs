namespace P04_Even_Times
{
    internal class Program
    {
        static void Main()
        {
            var numbers = new Dictionary<int, int>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(num))
                    numbers[num] = 0;
                numbers[num]++;
            }

            foreach (var (num, count) in numbers)
                if (count % 2 == 0)
                    Console.WriteLine(num);
        }
    }
}
