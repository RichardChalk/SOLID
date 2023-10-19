namespace O_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape rectangle = new Rectangle { Width = 5, Height = 10 };
            IShape circle = new Circle { Radius = 5 };
            IShape triangle = new Triangle { Base = 5, Height = 10 };

            AreaCalculator calculator = new AreaCalculator();

            Console.WriteLine($"Area of Rectangle: {calculator.CalculateArea(rectangle)}");
            Console.WriteLine($"Area of Circle: {calculator.CalculateArea(circle)}");
            Console.WriteLine($"Area of Triangle: {calculator.CalculateArea(triangle)}");

            Console.ReadLine();
        }
    }
}