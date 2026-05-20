using System;

namespace Lab1_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Лабораторная работа №1. Вариант 12 (Класс Printer) ===\n");



            Console.WriteLine("--- Создание объектов ---");

            Printer defaultPrinter = new Printer();
            Console.WriteLine("Принтер (конструктор по умолчанию):");
            defaultPrinter.CheckStatus();
            //145
            Console.WriteLine();

            Printer myPrinter = new Printer("HP LaserJet 1010", "лазерный", "готов", 0);
            Console.WriteLine("Принтер (конструктор с параметрами):");
            myPrinter.CheckStatus();

            Console.WriteLine("\n" + new string('-', 50) + "\n");



            Console.WriteLine("--- Демонстрация методов ---");

            Console.WriteLine("1. Проверка статуса:");
            myPrinter.CheckStatus();

            Console.WriteLine();
            Console.WriteLine("2. Печать документа (5 страниц):");
            myPrinter.PrintDocument(5);

            Console.WriteLine();


            Console.WriteLine("3. Печать еще одного документа (3 страницы):");
            myPrinter.PrintDocument(3);

            Console.WriteLine();


            Console.WriteLine("4. Проверка статуса после печати:");
            myPrinter.CheckStatus();

            Console.WriteLine();


            Console.WriteLine("5. Изменение статуса на 'нет бумаги' (ref параметр):");
            string newStatus = "нет бумаги";
            myPrinter.ChangeStatus(ref newStatus);

            Console.WriteLine();


            Console.WriteLine("6. Попытка печати при статусе 'нет бумаги':");
            myPrinter.PrintDocument(2);

            Console.WriteLine();


            Console.WriteLine("7. Очистка очереди:");
            myPrinter.ClearQueue();

            Console.WriteLine();


            Console.WriteLine("8. Проверка статуса после очистки:");
            myPrinter.CheckStatus();

            Console.WriteLine();

            //1
            Console.WriteLine("9. Получение информации о принтере (out параметр):");
            myPrinter.GetPrinterInfo(out string printerInfo);
            Console.WriteLine(printerInfo);

            Console.WriteLine();


            Console.WriteLine("10. Печать нескольких документов (params параметр):");
            myPrinter.Status = "готов";
            myPrinter.PrintMultiple(10, 7, 3, 5);

            Console.WriteLine();


            Console.WriteLine("11. Финальная проверка статуса:");
            myPrinter.CheckStatus();



            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("Программа завершена. Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}




