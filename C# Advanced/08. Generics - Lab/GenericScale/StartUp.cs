namespace GenericScale
{
    internal class StartUp
    {
        public static void Main(string[] args)
        {
            EqualityScale<string> scale = new EqualityScale<string>("tuk","tam");
            Console.WriteLine(scale.AreEqual());
        }
    }
}