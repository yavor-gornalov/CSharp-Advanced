namespace RecursiveFactorial
{
    internal class RecursiveFactorial
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Facorial(number));
        }

        public static long Facorial(long number)
        {
            if (number <= 1)
                return 1;
            return number * Facorial(number - 1);
        }
    }
}
