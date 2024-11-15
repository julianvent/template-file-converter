using Spire.Doc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

class ConvertFromDocx<I> : AbstractFileConverter<Document> {
    protected override string SetInputFile(string fileName)
    {
        return fileName + ".docx";
    }

    protected override Document GetDocument(string inputPath) 
    {
        return new Document();
    }

    protected override int GetPageCount(Document document)
    {
        return document.PageCount;
    }

    protected override void SavePageAsImage(Document document, int pageNumber)
    {
        using (System.Drawing.Image pageAsImage = document.SaveToImages(pageNumber, Spire.Doc.Documents.ImageType.Bitmap))
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pageAsImage.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                ms.Seek(0, SeekOrigin.Begin);

                using (var image = SixLabors.ImageSharp.Image.Load<Rgba32>(ms))
                {
                    return Image
                }
            }
        }
    }
}