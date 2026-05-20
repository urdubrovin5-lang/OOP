using System;


public class Device : IConnectable
{
    public string Name { get; }
    public bool IsConnected { get; set; }

    public Device(string name)
    {
        Name = name;
        IsConnected = false;
    }

    public void Connect() => IsConnected = true;
    public void Disconnect() => IsConnected = false;

    public override string ToString() => $"{Name} ({(IsConnected ? "подключено" : "отключено")})";
}