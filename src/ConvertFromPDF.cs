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

    protected override string SetOutputPath(string fileName, int pageNumber)
    {
        return Path.Combine(defaultPath, $"{fileName}_{EXTENSION[1..]}_{pageNumber}{OUTPUT_EXTENSION}");
    }


    protected override void SavePageAsImage(Document document, int pageNumber, string outputPath)
    {
        var extractedPage = document.ExtractPages(pageNumber, 1);
        extractedPage.Save(outputPath);
    }
}