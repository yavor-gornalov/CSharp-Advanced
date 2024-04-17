namespace GenericBoxOfString
{
    internal class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                var box = new Box<string>(value);
                Console.WriteLine(box);
            }
        }
    }
}
