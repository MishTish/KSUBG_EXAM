namespace Task_31
{
    class Program
    {
        static void Main()
        {
            ElectronicProduct laptop = new ElectronicProduct("PC", 2000.00, 36);
            ClothingProduct tshirt = new ClothingProduct("Jeans", 20.99, "S");

            Console.WriteLine("=== Electronic Product ===");
            laptop.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("=== Clothing Product ===");
            tshirt.PrintInfo();
        }
    }
}