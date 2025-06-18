namespace Task_31
{
    public class ClothingProduct : Product
    {
        public string Size { get; set; }

        public ClothingProduct(string name, double price, string size)
            : base(name, price)
        {
            Size = size;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Size: {Size}");
        }
    }
}
