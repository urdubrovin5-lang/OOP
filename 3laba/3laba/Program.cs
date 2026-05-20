using System;
using System.Collections.Generic;
using System.Linq;

{
    var textFS = new FileSystem<TextFile>();
    var imageFS = new FileSystem<ImageFile>();
    var programFS = new FileSystem<ProgramFile>();


    textFS.AddFile(new TextFile("doc.txt", 100, DateTime.Now, "UTF-8"));
    textFS.AddFile(new TextFile("note.txt", 500, DateTime.Now, "ASCII"));

    imageFS.AddFile(new ImageFile("photo.jpg", 1000, DateTime.Now, "1920x1080"));
    imageFS.AddFile(new ImageFile("icon.png", 50, DateTime.Now, "64x64"));

    programFS.AddFile(new ProgramFile("setup.exe", 5000, DateTime.Now, "Windows"));
    programFS.AddFile(new ProgramFile("app.bin", 3000, DateTime.Now, "Linux"));


    textFS.ExecuteAll();
    imageFS.ExecuteAll();
    programFS.ExecuteAll();


    Console.WriteLine("\nФайлы меньше 1000:");
    var smallFiles = textFS.FindBySize(1000);
    foreach (var file in smallFiles)
    {
        Console.WriteLine($"- {file.Name} ({file.Size})");
    }

    Console.WriteLine($"\nСоздано файловых систем: {FileSystem<TextFile>.FileSystemCount}");

}