using System;
using Chapter_4._Advanced_C_;

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

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}