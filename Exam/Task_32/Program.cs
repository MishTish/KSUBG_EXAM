namespace Task_32
{
    class Program
    {
        static void Main()
        {
            string[] docTypes = { "pdf", "word", "excel" };

            foreach (var type in docTypes)
            {
                Document doc = DocumentFactory.CreateDocument(type);
                Console.WriteLine($"\n--- {type.ToUpper()} ---");
                doc.PrepareForPrinting();
            }
        }
    }
}