abstract class AbstractFileConverter<T>
{
    protected const string OUTPUT_EXTENSION = ".jpg";
    protected string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    public void Conversion(string fileName)
    {
        string inputPath = SetInputPath(fileName);
        T document = GetDocument(inputPath);
        int pageCount = GetPageCount(document);

        Console.WriteLine(pageCount);
        for (int pageNumber = 0; pageNumber < pageCount; pageNumber++)
        {
            Console.Write(pageNumber + " ");
            SavePageAsImage(document, pageNumber, SetOutputPath(fileName, pageNumber));
        }
    }

    // delegar a clases concretas
    protected abstract string SetInputPath(string fileName);
    protected abstract void SavePageAsImage(T document, int pageNumber, string outputPath);
    protected abstract T GetDocument(string inputPath);
    protected abstract int GetPageCount(T document);
    protected abstract void LoadDocumentFile(T document, string inputPath);

    // métodos default
    protected string SetOutputPath(string fileName, int pageNumber)
    {
        return Path.Combine(defaultPath, fileName + "_" + pageNumber + OUTPUT_EXTENSION);
    }
}