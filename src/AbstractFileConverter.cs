abstract class AbstractFileConverter<T>
{
    protected const string OUTPUT_EXTENSION = ".jpg";
    protected string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    public void Conversion(string fileName)
    {
        string inputPath = SetInputPath(fileName);
        // string outputPath = SetOutputPath(fileName);
        T document = GetDocument(inputPath);
        int pageCount = GetPageCount(document);

        for (int i = 0; i < pageCount; i++)
        {
        SavePagesAsImages(inputPath, fileName, i);
        }
    }

    // delegar a clases concretas
    protected abstract string SetInputPath(string fileName);
    protected abstract void SavePagesAsImages(T document, string outputPath, int pageNumber);
    protected abstract T GetDocument(string inputPath);
    protected abstract int GetPageCount(T document);

    // métodos default
    protected string SetOutputPath(string fileName)
    {
        return Path.Combine(defaultPath, fileName + OUTPUT_EXTENSION);
    }
}