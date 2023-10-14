namespace _4_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Not a problem for me!
            // I'm working!
            Console.WriteLine("Worker");
            var imWorking = new Worker();
            imWorking.Work();


            // Du behöver inte vara mean!!
            // Jag har inget arbete!
            Console.WriteLine("\nUnemployed");
            var imNotWorking = new Unemployed();
            imNotWorking.Work();
        }
    }
}