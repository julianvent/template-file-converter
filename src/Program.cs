using Pdf = Aspose.Words.Document;
using Word = Spire.Doc.Document;

class Program
{
    public static void Main(string[] args)
    {
        AbstractFileConverter<Word> converter = new ConvertFromDocx();
        AbstractFileConverter<Pdf> pdfConverter = new ConvertFromPDF();
        converter.Conversion("holamundo");
        pdfConverter.Conversion("holamundo");
    }
}