using System;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=== Примеры из главы 4: Advanced C# ===\n");

            Console.WriteLine("--- Пример: Лямбда-выражения ---");
            LambdaExpressions lambdaDemo = new LambdaExpressions();
            lambdaDemo.ShowActions();
            lambdaDemo.ShowOtherActions();
            lambdaDemo.BasicLambdaSyntax();
            lambdaDemo.LambdaCapture();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Обработка исключений ---");
            ExceptionHandling exceptionDemo = new ExceptionHandling();
            exceptionDemo.BasicTryCatch();
            exceptionDemo.MultipleCatchBlocks();
            exceptionDemo.FinallyBlock();
            exceptionDemo.ExceptionFilters();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Перечисление и итераторы ---");
            EnumerationAndIterators enumDemo = new EnumerationAndIterators();
            enumDemo.Enumeration();
            enumDemo.CollectionInitializers();
            enumDemo.Iterators();
            enumDemo.IteratorSemantics(false);
            enumDemo.IteratorSemantics(true);
            enumDemo.ComposingSequences();
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}