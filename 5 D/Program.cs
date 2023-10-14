namespace _5_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch wallSwitch = new Switch();

            Console.WriteLine("Tryck på strömbrytaren:");
            wallSwitch.Toggle();
            wallSwitch.Toggle();
            wallSwitch.Toggle();

            Console.ReadLine();
        }
    }
}