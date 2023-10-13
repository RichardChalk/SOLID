namespace L_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IForm rektangel = new Rectangle
            {
                Width = 5,
                Height = 10
            };

            // Förväntat resultat: 50
            Console.WriteLine($"Rektangel Area: {rektangel.Area()}");

            IForm kvadrat = new Square
            {
                Side = 5
            };

            // Förväntat resultat: 25
            Console.WriteLine($"Kvadrats Area: {kvadrat.Area()}");

            IForm triangle = new Triangle
            {
                Base = 10,
                Height = 12
            };

            // Förväntat resultat: 60
            Console.WriteLine($"Trianglens Area: {triangle.Area()}");
        }
    }
}