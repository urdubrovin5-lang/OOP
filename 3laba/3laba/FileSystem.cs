public class FileSystem<T> where T : File, IExecutable
{
    private List<T> files = new List<T>();
    private static int fileSystemCount = 0;

    public FileSystem()
    {
        fileSystemCount++;
    }

    public static int FileSystemCount
    {
        get { return fileSystemCount; }
        set { fileSystemCount = value; }
    }

    public void AddFile(T file)
    {
        files.Add(file);
        Console.WriteLine($"Файл {file.Name} добавлен");
    }

    public void ExecuteAll()
    {
        Console.WriteLine($"\nВыполнение всех файлов ({files.Count} шт.):");
        foreach (var file in files)
        {
            file.Execute();
        }
    }

    public List<T> FindBySize(long maxSize)
    {
        return files.Where(f => f.Size <= maxSize).ToList();
    }

}