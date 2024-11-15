abstract class AbstractFileConverter
{
    protected const string OUTPUT_EXTENSION = ".jpg";
    protected string defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    public void Conversion(string fileName)
    {
        string inputPath = SetInputPath(fileName);
        string outputPath = SetOutputPath(fileName);

        SavePagesAsImages(inputPath, fileName);
    }

    // delegar a clases concretas
    protected abstract string SetInputPath(string fileName);
    protected abstract void SavePagesAsImages(string inputPath, string outputPath);

    // métodos default
    protected string SetOutputPath(string fileName)
    {
        return Path.Combine(defaultPath, fileName + OUTPUT_EXTENSION);
    }
}