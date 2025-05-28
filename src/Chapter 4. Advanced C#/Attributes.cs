using System;
using System.Runtime.CompilerServices;

namespace Chapter4 {
    public class Attributes {
        public void CallerInfoAttributes() {
            Console.WriteLine("Демонстрация атрибутов информации о вызывающей стороне:");
            
            Console.WriteLine("\nВызов ShowCallerInfo() без параметров:");
            ShowCallerInfo();
            
            Console.WriteLine("\nВызов ShowCallerInfo() с явно указанным именем:");
            ShowCallerInfo("Явно указанное имя");
        }

        public void CallerArgumentExpressionDemo() {
            Console.WriteLine("\nДемонстрация атрибута CallerArgumentExpression (C# 10+):");
            
            double value = 42.5;
            Console.WriteLine($"Значение переменной value: {value}");
            
            Console.WriteLine("\nВызов Print(value):");
            Print(value);
            
            Console.WriteLine("\nВызов Print(value * 2):");
            Print(value * 2);
            
            Console.WriteLine("\nВызов Print(Math.Sqrt(value)):");
            Print(Math.Sqrt(value));
        }

        public void AssertDemo() {
            Console.WriteLine("\nДемонстрация использования Assert с CallerArgumentExpression:");
            
            int x = 5, y = 10;
            Console.WriteLine($"x = {x}, y = {y}");
            
            Console.WriteLine("\nВызов Assert(x < y):");
            Assert(x < y);
            
            Console.WriteLine("\nВызов Assert(x > y):");
            Assert(x > y);
            
            Console.WriteLine("\nВызов Assert(x * 2 == y):");
            Assert(x * 2 == y);
        }

        public void Print(double number, [CallerArgumentExpression("number")] string expression = null) {
            Console.WriteLine($"Значение: {number}");
            Console.WriteLine($"Выражение: {expression}");
        }

        public void Assert(bool condition, [CallerArgumentExpression("condition")] string expression = null) {
            if (condition) {
                Console.WriteLine($"Проверка успешна: {expression} = true");
            } else {
                Console.WriteLine($"Проверка не пройдена: {expression} = false");
            }
        }

        private void ShowCallerInfo(
            [CallerMemberName] string memberName = null,
            [CallerFilePath] string filePath = null,
            [CallerLineNumber] int lineNumber = 0
            ) {
            Console.WriteLine($"Имя вызывающего метода: {memberName}");
            Console.WriteLine($"Путь к файлу: {filePath}");
            Console.WriteLine($"Номер строки: {lineNumber}");
        }
    }
}