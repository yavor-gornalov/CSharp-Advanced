namespace P09_Simple_Text_Editor
{
    internal class Program
    {
        static void Main()
        {
            var textState = new Stack<string>();

            int N = int.Parse(Console.ReadLine());

            string text = "";
            for (int i = 0; i < N; i++)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                var command = tokens[0];
                switch (command)
                {
                    case "1":
                        {
                            textState.Push(text);

                            var str = tokens[1];
                            text += str;
                            break;
                        }
                    case "2":
                        {
                            textState.Push(text);

                            var count = int.Parse(tokens[1]);
                            text = text.Remove(text.Length - count, count);
                            break;
                        }
                    case "3":
                        {
                            var index = int.Parse(tokens[1]) - 1;
                            Console.WriteLine(text[index]);
                            break;
                        }
                    case "4":
                        {
                            if (textState.Count > 0)
                            {
                                var oldText = textState.Pop();
                                text = oldText;
                            }
                            break;
                        }
                }
            }
        }
    }
}
