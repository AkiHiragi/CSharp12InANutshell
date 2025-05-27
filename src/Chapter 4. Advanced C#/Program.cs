using System;
using Chapter_4._Advanced_C_;
using Chapter4;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=== Примеры из главы 4: Продвинутый C# ===\n");

            Console.WriteLine("--- ДЕЛЕГАТЫ ---");
            var delegates = new Delegates();
            delegates.Transformer();
            Console.WriteLine();
            delegates.Transformer2();
            Console.WriteLine();
            delegates.MulticastDelegates();
            Console.WriteLine();

            Console.WriteLine("--- СОБЫТИЯ ---");
            var events = new Events();
            events.EventShow();
            Console.WriteLine();
            events.MultipleSubscribers();
            Console.WriteLine();

            Console.WriteLine("--- NULLABLE ТИПЫ ---");
            var nullableTypes = new NullableValueTypes();
            nullableTypes.NullableTStruct();
            Console.WriteLine();
            nullableTypes.ImplicitAndExplicitNullableConversions();
            Console.WriteLine();
            nullableTypes.BoxingAndUnboxingNullableValues();
            Console.WriteLine();
            
            Console.WriteLine("--- МЕТОДЫ РАСШИРЕНИЯ И АНОНИМНЫЕ ТИПЫ ---");
            var extensions = new ExtensionMethods();
            extensions.IsCapitalized();
            Console.WriteLine();
            extensions.AnonymousTypes();
            Console.WriteLine();
            extensions.ChainingExtensionMethods();
            Console.WriteLine();
            
            Console.WriteLine("--- КОРТЕЖИ ---");
            var tuples = new Tuples();
            tuples.TuplesDemonstration();
            Console.WriteLine();
            tuples.DeconstructingTuples();
            Console.WriteLine();
            tuples.NamedTuples();
            Console.WriteLine();
            tuples.TuplesAsReturnValues();
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}