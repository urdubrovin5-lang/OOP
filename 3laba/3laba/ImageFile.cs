using System.Xml.Linq;

public class ImageFile : File, IExecutable
{
    public string Resolution { get; set; }

    public ImageFile(string name, long size, DateTime creationDate, string resolution)
        : base(name, size, creationDate)
    {
        Resolution = resolution;
    }

    public void Execute()
    {
        Console.WriteLine($"Открываю изображение {Name} (разрешение: {Resolution})");
    }
}