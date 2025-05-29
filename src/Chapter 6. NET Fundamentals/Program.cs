using System;

namespace Chapter_6._NET_Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Примеры из главы 6: .NET Fundamentals ===\n");

            Console.WriteLine("--- Работа со строками и текстом ---");
            StringAndTextHandling textDemo = new StringAndTextHandling();
            
            Console.WriteLine("\n-- Работа с символами (char) --");
            textDemo.CharShow();
            
            Console.WriteLine("\n--- Работа с датами и временем ---");
            DatesAndTimes dateTimeDemo = new DatesAndTimes();
            
            Console.WriteLine("\n-- Работа с TimeSpan --");
            dateTimeDemo.TimeSpanShow();
            
            Console.WriteLine("\n-- Работа с DateTime --");
            dateTimeDemo.DateTimeShow();
            
            Console.WriteLine("\n-- Работа с DateTimeOffset --");
            dateTimeDemo.DateTimeOffsetShow();
            
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}