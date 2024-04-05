namespace UML2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.Test();
            Console.Write("Please press any key to return to user dialog");
            Console.ReadKey();
        
            store.Start();
        }
    }
}
