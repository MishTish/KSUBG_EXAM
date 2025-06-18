namespace Task_29
{
    public class Square : Shape, IDrawable
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }

        public override double CalculateArea()
        {
            return Side * Side;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing a Square with side {Side}");
        }
    }
}
