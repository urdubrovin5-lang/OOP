namespace Interface
{
    public interface IConnectable
    {
        void Connect();
        void Disconnect();
        bool IsConnected { get; }
    }
}