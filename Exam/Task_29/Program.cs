namespace Task_29 {
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>
        {
            new Circle(10),
            new Square(23),
            new Triangle(4, 2)
        };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Area: {shape.CalculateArea():F2}");

                if (shape is IDrawable drawable)
                {
                    drawable.Draw();
                }

                Console.WriteLine();
            }
        }
    }
}