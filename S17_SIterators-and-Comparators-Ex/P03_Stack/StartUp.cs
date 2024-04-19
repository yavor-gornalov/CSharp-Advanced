namespace Stack
{
    internal class StartUp
    {
        static void Main()
        {
            var myStack = new CustomStack<string>();
            var delims = new char[] { ',', ' ' };


            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                if (line.StartsWith("Pop"))
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("No elements");
                    }
                }
                else if (line.StartsWith("Push"))
                {
                    var elements = line
                        .Split(delims, StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .ToArray();
                    myStack.Push(elements);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(String.Join("\n", myStack));
            }
        }
    }
}
