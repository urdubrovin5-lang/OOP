using System;

class Program
{
    static void Main()
    {

        Device laptop = new Device("Ноутбук");
        Device phone = new Device("Телефон");
        Device printer = new Device("Принтер");
        Device router = new Device("Роутер");


        Network<Device> officeNetwork = new Network<Device>();
        Network<Device> homeNetwork = new Network<Device>();


        officeNetwork = officeNetwork + laptop;
        officeNetwork = officeNetwork + printer;
        officeNetwork = officeNetwork + router;

        homeNetwork = homeNetwork + laptop;
        homeNetwork = homeNetwork + phone;

        Console.WriteLine("Офисная сеть");
        officeNetwork.ShowDevices();

        Console.WriteLine("\n=== Домашняя сеть ===");
        homeNetwork.ShowDevices();


        var commonNetwork = officeNetwork & homeNetwork;
        Console.WriteLine("\nОбщие устройства (пересечение сетей)");
        commonNetwork.ShowDevices();


        Console.WriteLine("\nПереключение подключения ноутбука");
        Console.WriteLine($"До: {laptop}");
        laptop.ToggleConnection();
        Console.WriteLine($"После Toggle: {laptop}");
        laptop.ToggleConnection();
        Console.WriteLine($"Ещё раз Toggle: {laptop}");


        Console.WriteLine("\n=== Удаляем принтер из офисной сети ===");
        officeNetwork = officeNetwork - printer;
        officeNetwork.ShowDevices();
    }
}