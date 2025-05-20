using System;
using Animals;

namespace Chapter2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=== Примеры из главы 2: C# Language Basics ===\n");

            Console.WriteLine("--- Пример 2.1: Основы синтаксиса ---");
            Examples.Statement1();
            Console.WriteLine($"12 футов = {Examples.FeetToInches(12)} дюймов");
            Examples.SayHello();
            Console.WriteLine();

            Console.WriteLine("--- Пример 2.2: Типы и переменные ---");
            Examples.Statement2();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Конвертер единиц измерения ---");
            Examples.UnitConverter();
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");

            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");
            Console.WriteLine(p1.Name); // Pan Dee
            Console.WriteLine(p2.Name); // Pan Dah
            Console.WriteLine(Panda.Population); // 2
        }
    }
}