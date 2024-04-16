namespace GenericScale
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var equalScale = new EqualityScale<int>(2, 5);
            Console.WriteLine(equalScale.AreEqual());
        }
    }
}
