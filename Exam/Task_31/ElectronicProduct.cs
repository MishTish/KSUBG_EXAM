namespace Task_31
{
    public class ElectronicProduct : Product
    {
        public int WarrantyPeriod { get; set; }

        public ElectronicProduct(string name, double price, int warrantyPeriod)
            : base(name, price)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Warranty Period: {WarrantyPeriod} months");
        }
    }
}
