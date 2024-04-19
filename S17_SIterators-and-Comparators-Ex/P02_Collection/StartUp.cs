namespace Collection
{
    public class StartUp
    {
        static void Main()
        {
            var tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            var listy = new ListyIterator<string>(tokens);

            while (true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "Move":
                        {
                            Console.WriteLine(listy.Move());
                            break;
                        }
                    case "HasNext":
                        {
                            Console.WriteLine(listy.HasNext());
                            break;
                        }
                    case "Print":
                        {
                            try
                            {
                                listy.Print();
                            } catch (InvalidOperationException) {
                                Console.WriteLine("Invalid Operation!");
                            }
                            break;
                        }
                    case "PrintAll":
                        {
                            Console.WriteLine(String.Join(" ", listy));
                            break;
                        }
                    case "END": return;
                }
            }
        }
    }
}
