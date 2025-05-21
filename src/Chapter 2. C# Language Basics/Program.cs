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

            Console.WriteLine("--- Пример: Работа с классом Panda ---");
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");
            Console.WriteLine($"Имя панды 1: {p1.Name}");
            Console.WriteLine($"Имя панды 2: {p2.Name}");
            Console.WriteLine($"Популяция панд: {Panda.Population}");
            Console.WriteLine();

            Console.WriteLine("--- Пример: Проверка переполнения ---");
            Examples.Checked();
            Console.WriteLine();
            
            Console.WriteLine("--- Пример: Специальные значения float и double ---");
            Examples.SpecialFloatAndDoubleValues();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Работа со строками ---");
            StringType stringDemo = new StringType();
            
            Console.WriteLine("Сравнение строк:");
            stringDemo.Equaling();
            
            Console.WriteLine("\nДословные строки (@):");
            stringDemo.Verbalism();
            
            Console.WriteLine("\nИнтерполяция строк ($):");
            stringDemo.Interpolation();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Работа с массивами ---");
            Arrays arrayDemo = new Arrays();
            arrayDemo.IndicesAndRanges();
            arrayDemo.MultiDimensionalArray();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Выражения и операторы ---");
            ExpressionsAndOperators expDemo = new ExpressionsAndOperators();
            expDemo.AssignmentExpressions();
            expDemo.ArithmeticOperators();
            expDemo.LogicalOperators();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Операторы для работы с null ---");
            NullOperators nullDemo = new NullOperators();
            nullDemo.NullConditionalOperator();
            nullDemo.NullCoalescingOperator();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Операторы управления потоком ---");
            Statements statementsDemo = new Statements();
            statementsDemo.SelectionStatements();
            statementsDemo.IterationStatements();
            statementsDemo.JumpStatements();
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}