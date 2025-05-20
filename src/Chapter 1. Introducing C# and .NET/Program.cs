using System;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Примеры из главы 1: Introducing C# and .NET ===\n");
            
            Console.WriteLine("--- Пример 1: Базовая программа ---");
            Examples.BasicProgram();
            Console.WriteLine();
            
            Console.WriteLine("--- Пример 2: Процесс компиляции ---");
            Examples.CompilationExample();
            Console.WriteLine();
            
            Console.WriteLine("--- Пример 3: Базовые типы .NET ---");
            Examples.DotNetTypes();
            Console.WriteLine();
            
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}