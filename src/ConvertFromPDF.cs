using Aspose.Words;

class ConvertFromPDF : AbstractFileConverter<Document>
{
    protected override string SetInputPath(string fileName)
    {
        throw new NotImplementedException();
    }
    protected override Document GetDocument(string inputPath)
    {
        throw new NotImplementedException();
    }

    protected override int GetPageCount(Document document)
    {
        throw new NotImplementedException();
    }

    protected override void SavePageAsImage(Document document, int pageNumber, string outputPath)
    {
        throw new NotImplementedException();
    }

    protected override void LoadDocumentFile(Document document, string inputPath)
    {
        throw new NotImplementedException();
    }
}