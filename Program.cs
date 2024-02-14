namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ShelfContext context = new ShelfContext();
            context.Database.EnsureDeleted();
            Console.WriteLine("database deleted");
            context.Database.EnsureCreated();
            Console.WriteLine("database Created");
        }
    }
}
