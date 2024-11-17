using Aspose.Words;

class ConvertFromPDF : AbstractFileConverter<Document>
{
    const string EXTENSION = ".pdf";
    protected override string SetInputPath(string fileName)
    {
        return Path.Combine(defaultPath, fileName + EXTENSION);
    }
    protected override Document GetDocument(string inputPath)
    {
        return new Document(inputPath);
    }

    protected override int GetPageCount(Document document)
    {
        return document.PageCount;
    }

    protected override void SavePageAsImage(Document document, int pageNumber, string outputPath)
    {
        var extractedPage = document.ExtractPages(pageNumber, 1);
        extractedPage.Save(outputPath);
    }
}