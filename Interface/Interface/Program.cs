using Interface;

public class DeviceManager
{
    private List<IConnectable> devices;

    public DeviceManager()
    {
        devices = new List<IConnectable>();
    }

    public void InitializeDevices()
    {
        devices.AddRange(new IConnectable[]
        {
            new Printer("Лазерный", "HP LaserJet Pro"),
            new Scanner(1200, "Epson Perfection"),
            new NetworkRouter("6", "TP-Link Archer", 4)
        });
    }

    public void ShowDemo()
    {
        Console.WriteLine("ДЕМОНСТРАЦИЯ РАБОТЫ УСТРОЙСТВ");

    }
}

class Program
{
    static void Main()
    {
        DeviceManager manager = new DeviceManager();
        manager.InitializeDevices();
        manager.ShowDemo();
    }
}