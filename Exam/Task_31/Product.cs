namespace Task_31
{
    public class Product
    {

        protected static int productCount = 0;


        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
            productCount++;
        }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Price: ${Price:F2}");
            Console.WriteLine($"Total Products Created: {productCount}");
        }
    }
}
