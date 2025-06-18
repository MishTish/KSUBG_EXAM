namespace Task_29
{
    public class Triangle : Shape, IDrawable
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double b, double h)
        {
            Base = b;
            Height = h;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a Triangle with base {Base} and height {Height}");
        }
    }
}
