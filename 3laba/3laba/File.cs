public class File
{
    public string Name { get; set; }
    public long Size { get; set; }
    public DateTime CreationDate { get; set; }

    public File(string name, long size, DateTime creationDate)
    {
        Name = name;
        Size = size;
        CreationDate = creationDate;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}, Размер: {Size}, Дата: {CreationDate}");
    }
}