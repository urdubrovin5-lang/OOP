public static class ConnectableExtensions
{
    public static void ToggleConnection(this IConnectable device)
    {
        if (device.IsConnected)
            device.Disconnect();
        else
            device.Connect();
    }
}