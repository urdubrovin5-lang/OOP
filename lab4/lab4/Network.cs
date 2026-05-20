using System;
using System.Collections.Generic;
using System.Linq;


public class Network<T> where T : IConnectable
{
    private List<T> devices = new List<T>();

    public IReadOnlyList<T> Devices => devices;


    public void Add(T device) => devices.Add(device);


    public bool Remove(T device) => devices.Remove(device);


    public static Network<T> operator +(Network<T> network, T device)
    {
        network.Add(device);
        return network;
    }


    public static Network<T> operator -(Network<T> network, T device)
    {
        network.Remove(device);
        return network;
    }


    public static Network<T> operator &(Network<T> a, Network<T> b)
    {
        var result = new Network<T>();
        var common = a.devices.Intersect(b.devices);
        foreach (var device in common)
            result.Add(device);
        return result;
    }

    public void ShowDevices()
    {
        foreach (var d in devices)
            Console.WriteLine(d);
    }
}