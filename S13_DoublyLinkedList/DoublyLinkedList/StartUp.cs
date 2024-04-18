namespace CustomDoublyLinkedList
{
    internal class Test
    {
        static void Main()
        {
            var dll = new CustomDoublyLinkedList<int>();

            dll.AddFirst(1);
            dll.AddFirst(5);
            dll.AddLast(3);
            dll.AddLast(4);
            dll.AddLast(5);

            dll.RemoveLast();
            dll.RemoveFirst();

            dll.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"DoublyLinkedList Count: {dll.Count}");

            int[] arr = dll.ToArray();
            Console.WriteLine(arr[1]);
        }
    }
}
