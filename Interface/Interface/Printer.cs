using System;

namespace Interface
{
    public class Printer : IConnectable
    {
        private string printType;
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

        public Printer(string printType, string model)
        {
            this.printType = printType;
            this.model = model;
            this.connected = false;
        }

        public void Connect()
        {
            if (!connected)
            {
                connected = true;
                Console.WriteLine($"[Printer] {model} ({printType} принтер) подключён.");
            }
            else
            {
                Console.WriteLine($"[Printer] {model} уже подключён.");
            }
        }

        public void Disconnect()
        {
            if (connected)
            {
                connected = false;
                Console.WriteLine($"[Printer] {model} отключён.");
            }
            else
            {
                Console.WriteLine($"[Printer] {model} уже отключён.");
            }
        }

        public void Print(string document)
        {
            if (connected)
            {
                Console.WriteLine($"[Printer] {model} печатает: {document}");
            }
            else
            {
                Console.WriteLine($"[Printer] {model} не подключён. Невозможно печатать.");
            }
        }
    }
}