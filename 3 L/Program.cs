namespace _3_L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rektangel = new Rectangle
            {
                Width = 5,
                Height = 10
            };

            // Förväntat resultat: 50
            Console.WriteLine($"Rektangel Area: {rektangel.Area()}");

            // Använder en Kvadrat och förväntar oss att det ska bete sig som en Rektangel
            Rectangle kvadratSomRektangel = new Square();
            kvadratSomRektangel.Width = 5;
            kvadratSomRektangel.Height = 10;

            // Oväntat resultat: 100
            // Det blir H*H (10*10)!
            // Inte korrekt!
            Console.WriteLine($"Kvadrat Som Rektangel Area: {kvadratSomRektangel.Area()}");  
        }
    }
}