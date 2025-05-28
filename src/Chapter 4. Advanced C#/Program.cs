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

            Console.WriteLine("--- Пример: Шаблоны сопоставления (Patterns) ---");
            Patterns patternsDemo = new Patterns();
            patternsDemo.ConstantPattern();
            patternsDemo.RelationalPatterns(24.5m);
            patternsDemo.VarPattern("Jane");
            patternsDemo.TupleAndPositionalPatterns();
            patternsDemo.PropertyPatterns(new Uri("https://example.com"));
            patternsDemo.ListPatterns();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Атрибуты ---");
            Attributes attributesDemo = new Attributes();
            attributesDemo.CallerInfoAttributes();
            attributesDemo.CallerArgumentExpressionDemo();
            attributesDemo.AssertDemo();
            Console.WriteLine();

            Console.WriteLine("--- Пример: Динамическая привязка (dynamic) ---");
            DynamicBinding dynamicDemo = new DynamicBinding();
            dynamicDemo.CustomBinding();
            dynamicDemo.LanguageBinding();
            dynamicDemo.RuntimeBinderException();
            dynamicDemo.RuntimeRepresentationOfDynamic();
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}