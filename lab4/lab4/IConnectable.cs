using System;


public interface IConnectable
{
    bool IsConnected { get; set; }
    string Name { get; }
    void Connect();
    void Disconnect();
}