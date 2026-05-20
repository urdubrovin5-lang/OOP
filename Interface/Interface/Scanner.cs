using System;

namespace Interface
{
    public class Scanner : IConnectable
    {
        private int resolution;
        private bool connected;
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public bool IsConnected
        {
            get { return connected; }
        }

        public Scanner(int resolution, string model)
        {
            this.resolution = resolution;
            this.model = model;
            this.connected = false;
        }

        public void Connect()
        {
            if (!connected)
            {
                connected = true;
                Console.WriteLine($"[Scanner] {model} ({resolution} dpi) подключён.");
            }
            else
            {
                Console.WriteLine($"[Scanner] {model} уже подключён.");
            }
        }

        public void Disconnect()
        {
            if (connected)
            {
                connected = false;
                Console.WriteLine($"[Scanner] {model} отключён.");
            }
            else
            {
                Console.WriteLine($"[Scanner] {model} уже отключён.");
            }
        }

        public void Scan()
        {
            if (connected)
            {
                Console.WriteLine($"[Scanner] {model} сканирует с разрешением {resolution} dpi");
            }
            else
            {
                Console.WriteLine($"[Scanner] {model} не подключён. Сканирование невозможно.");
            }
        }
    }
}