using System.Xml.Linq;

public class TextFile : File, IExecutable
{
    public string Encoding { get; set; }

    public TextFile(string name, long size, DateTime creationDate, string encoding)
        : base(name, size, creationDate)
    {
        Encoding = encoding;
    }

    public void Execute()
    {
        Console.WriteLine($"Открываю текстовый файл {Name} (кодировка: {Encoding})");
    }
}