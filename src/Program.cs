using Pdf = Aspose.Words.Document;
using Docx = Spire.Doc.Document;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(".: Conversion de archivos :.");
        Console.WriteLine("1. Docx a JPG");
        Console.WriteLine("2. PDF a JPG");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1: 
                AbstractFileConverter<Docx> docxConverter = new ConvertFromDocx(); 
                Console.Write("Ingresa el nombre del archivo: ");
                docxConverter.Conversion(Console.ReadLine());
                break;
            case 2:
                AbstractFileConverter<Pdf> pdfConverter = new ConvertFromPDF();
                Console.Write("Ingresa el nombre del archivo: ");
                pdfConverter.Conversion(Console.ReadLine());
                break;
            default: 
                break;
        }
    }
}