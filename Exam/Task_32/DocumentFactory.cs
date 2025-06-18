namespace Task_32
{
    public class DocumentFactory
    {
        public static Document CreateDocument(string type)
        {
            switch (type.ToLower())
            {
                case "pdf":
                    return new PDFDocument();
                case "word":
                    return new WordDocument();
                case "excel":
                    return new ExcelDocument();
                default:
                    throw new ArgumentException($"Unknown document type: {type}");
            }
        }
    }
}
