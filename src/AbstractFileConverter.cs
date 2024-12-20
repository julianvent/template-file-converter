abstract class AbstractFileConverter<T>
{
    protected const string OUTPUT_EXTENSION = ".jpg";
    protected string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    public void Conversion(string fileName)
    {
        string inputPath = SetInputPath(fileName);
        T document = GetDocument(inputPath);
        int pageCount = GetPageCount(document);

        Console.WriteLine($"Convirtiendo archivo {fileName}...");
        for (int pageNumber = 0; pageNumber < pageCount; pageNumber++)
        {
            Console.Write(pageNumber + " ");
            SavePageAsImage(document, pageNumber, SetOutputPath(fileName, pageNumber));
        }
        Console.WriteLine("Conversion terminada");
    }

    // delegar a clases concretas
    protected abstract string SetInputPath(string fileName);
    protected abstract T GetDocument(string inputPath);
    protected abstract int GetPageCount(T document);
    protected abstract string SetOutputPath(string fileName, int pageNumber);
    protected abstract void SavePageAsImage(T document, int pageNumber, string outputPath);
}