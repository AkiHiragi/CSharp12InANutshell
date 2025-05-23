using System;
using Chapter_3._Creating_Types_in_C_;

namespace Chapter3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=== Примеры из главы 3: Создание типов в C# ===\n");

            var objectDemo = new TheObjectType();

            Console.WriteLine("--- Демонстрация упаковки и распаковки ---");
            objectDemo.BoxingAndUnboxing();

            Console.WriteLine("--- Демонстрация понижающего приведения типов ---");
            objectDemo.DownCasting();

            Console.WriteLine("--- Демонстрация получения информации о типе ---");
            objectDemo.GetTypeMethod();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}