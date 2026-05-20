using System.Xml.Linq;

public class ProgramFile : File, IExecutable
{
    public string Platform { get; set; }

    public ProgramFile(string name, long size, DateTime creationDate, string platform)
        : base(name, size, creationDate)
    {
        Platform = platform;
    }

    public void Execute()
    {
        Console.WriteLine($"Запускаю программу {Name} (платформа: {Platform})");
    }
}