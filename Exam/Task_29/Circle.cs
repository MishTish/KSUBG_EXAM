
namespace Task_29
{
    public class Circle : Shape, IDrawable
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a Circle with radius {Radius}");
        }
    }
}
