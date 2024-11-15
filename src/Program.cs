class Program
{
    public static void Main(string[] args)
    {
        AbstractFileConverter converter = new ConvertFromDocx();
        converter.Conversion("ejemplo");
    }
}