abstract class AbstractFileConverter<T>() 
{
    const string OUTPUT_EXTENSION = ".jpg";

    void Conversion(string fileName)
    {
        string inputFile = SetInputFile(fileName);
        string inputPath = SetInputPath(inputFile);

        T document = GetDocument(inputPath);
        int pageCount =  GetPageCount(document);

        for (int i = 0; i < pageCount; i++)
        {
            var image = SavePageAsImage(document, i);
        }
    }

    // delegar a clases concretas
    protected abstract string SetInputFile(string fileName);
    protected abstract T GetDocument(string inputPath);
    protected abstract int GetPageCount(T document);
    protected abstract void SavePageAsImage(T document, int pageNumber);

    // métodos default
    private string SetInputPath(string inputFile) {
        return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + inputFile;
    }

}