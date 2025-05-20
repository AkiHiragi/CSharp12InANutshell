using System;

namespace Chapter3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=== Примеры из главы 3: Creating Types in C# ===\n");

            Console.WriteLine("--- Пример 1: Классы ---");
            Examples.ClassExample();
            Console.WriteLine();

            Console.WriteLine("--- Пример 2: Структуры ---");
            Examples.StructExample();
            Console.WriteLine();

            Console.WriteLine("--- Пример 3: Перечисления ---");
            Examples.EnumExample();
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}