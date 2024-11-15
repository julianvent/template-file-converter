using Spire.Doc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

class ConvertFromDocx : AbstractFileConverter<Document>
{
    const string EXTENSION = ".docx";
    protected override string SetInputPath(string fileName)
    {
        return Path.Combine(defaultPath, fileName + EXTENSION);
    }
    protected override void SavePagesAsImages(Document docxDocument, string inputPath, int pageNumber)
    {
        docxDocument.LoadFromFile(inputPath);
        using (System.Drawing.Image pageAsImage = docxDocument.SaveToImages(pageNumber, Spire.Doc.Documents.ImageType.Bitmap))
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pageAsImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                ms.Seek(0, SeekOrigin.Begin);

                using (var image = Image.Load<Rgba32>(ms))
                {
                    image.Save(Path.Combine(defaultPath, fileName + "_" + (pageNumber + 1) + OUTPUT_EXTENSION));
                }
            }
        }
    }

    protected override Document GetDocument(string inputPath)
    {
        return new Document();
    }

    protected override int GetPageCount(Document document)
    {
        return document.PageCount;
    }
}