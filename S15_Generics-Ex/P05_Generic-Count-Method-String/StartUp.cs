namespace GenericCountMethodString
{
    internal class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string element = Console.ReadLine();
                box.Add(element);
            }

            var item = Console.ReadLine();
            
            Console.WriteLine(box.CountOfGreaterElements(item));
        }
    }
}
