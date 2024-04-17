namespace GenericCountMethodStringDouble
{
    internal class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                double element = double.Parse(Console.ReadLine());
                box.Add(element);
            }

            var item = double.Parse( Console.ReadLine());
            
            Console.WriteLine(box.CountOfGreaterElements(item));
        }


    }
}
