using System;

namespace Interface
{
    public class NetworkRouter : IConnectable
    {
        private string wifiStandard;
        private bool connected;
        private string model;
        private int portCount;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public bool IsConnected
        {
            get { return connected; }
        }

        public NetworkRouter(string wifiStandard, string model, int portCount)
        {
            this.wifiStandard = wifiStandard;
            this.model = model;
            this.portCount = portCount;
            this.connected = false;
        }

        public void Connect()
        {
            if (!connected)
            {
                connected = true;
                Console.WriteLine($"[Router] {model} (Wi-Fi {wifiStandard}, {portCount} портов) подключён к сети.");
            }
            else
            {
                Console.WriteLine($"[Router] {model} уже подключён.");
            }
        }

        public void Disconnect()
        {
            if (connected)
            {
                connected = false;
                Console.WriteLine($"[Router] {model} отключён от сети.");
            }
            else
            {
                Console.WriteLine($"[Router] {model} уже отключён.");
            }
        }

        public void RouteData(string data)
        {
            if (connected)
            {
                Console.WriteLine($"[Router] {model} маршрутизирует данные: {data}");
            }
            else
            {
                Console.WriteLine($"[Router] {model} не подключён. Маршрутизация невозможна.");
            }
        }
    }
}