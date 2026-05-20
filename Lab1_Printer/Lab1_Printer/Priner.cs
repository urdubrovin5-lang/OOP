using System;

namespace Lab1_Printer
{
    public class Printer
    {
        //2
        private string _model;
        private string _printType;
        private string _status;
        private int _pagesInQueue;



        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public string PrintType
        {
            get { return _printType; }
            set { _printType = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }


        public int PagesInQueue
        {
            get { return _pagesInQueue; }
            set { _pagesInQueue = value; }
        }



        public Printer()
        {
            _model = "Unknown";
            _printType = "лазерный";
            _status = "готов";
            _pagesInQueue = 0;
        }



        public Printer(string model, string printType, string status, int pagesInQueue)
        {
            _model = model;
            _printType = printType;
            _status = status;
            _pagesInQueue = pagesInQueue;
        }


        public void PrintDocument(int pages)
        {
            if (_status != "готов")
            {
                Console.WriteLine($"Невозможно печатать: принтер не готов (статус: {_status})");
                return;
            }

            if (pages <= 0)
            {
                Console.WriteLine("Количество страниц должно быть положительным.");
                return;
            }

            Console.WriteLine($"Печать {pages} страниц...");
            _pagesInQueue += pages;
            Console.WriteLine($"Документ добавлен в очередь. Всего в очереди: {_pagesInQueue} стр.");
        }


        public void CheckStatus()
        {
            Console.WriteLine($"Модель: {_model}, Тип печати: {_printType}, Статус: {_status}, В очереди: {_pagesInQueue} стр.");
        }

        public void ClearQueue()
        {
            _pagesInQueue = 0;
            Console.WriteLine("Очередь печати очищена.");
        }



        public void ChangeStatus(ref string newStatus)
        {
            _status = newStatus;
            Console.WriteLine($"Статус изменён на: {_status}");
        }



        public void GetPrinterInfo(out string info)
        {
            info = $"Принтер {_model} ({_printType}) — статус: {_status}, страниц в очереди: {_pagesInQueue}";
        }



        public void PrintMultiple(params int[] pagesList)
        {
            Console.WriteLine("Печать нескольких документов:");
            foreach (int pages in pagesList)
            {
                PrintDocument(pages);
            }
        }


    }
}