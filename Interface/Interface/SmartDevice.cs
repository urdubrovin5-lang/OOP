using System;

namespace Interface
{
    public class SmartDevice : Device, IConnectable
    {
        private bool connected;
        private string osVersion;

        public bool IsConnected
        {
            get { return connected; }
        }

        public string OSVersion
        {
            get { return osVersion; }
            set { osVersion = value; }
        }

        public SmartDevice(string model, int powerConsumption, string osVersion)
            : base(model, powerConsumption)
        {
            this.osVersion = osVersion;
            this.connected = false;
        }

        public void Connect()
        {
            if (!connected)
            {
                connected = true;
                Console.WriteLine($"[SmartDevice] {model} (ОС: {osVersion}) подключён.");
            }
        }

        public void Disconnect()
        {
            if (connected)
            {
                connected = false;
                Console.WriteLine($"[SmartDevice] {model} отключён.");
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Умное устройство: {model}, мощность: {powerConsumption}Вт, ОС: {osVersion}");
        }
    }
}