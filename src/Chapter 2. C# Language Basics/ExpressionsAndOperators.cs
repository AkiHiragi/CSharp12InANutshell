using System;

namespace Chapter2 {
    public class ExpressionsAndOperators {
        public void AssignmentExpressions() {
            Console.WriteLine("Демонстрация выражений присваивания:");
            
            int x, y;
            Console.WriteLine("y = 5 * (x = 2)");
            y = 5 * (x = 2);
            Console.WriteLine($"Результат: x = {x}, y = {y}");
            
            Console.WriteLine("\nПобитовый сдвиг с присваиванием (x <<= 1):");
            Console.WriteLine($"x до сдвига: {x}");
            x <<= 1;
            Console.WriteLine($"x после сдвига: {x}");
        }
        
        public void ArithmeticOperators() {
            Console.WriteLine("\nАрифметические операторы:");
            
            int x = 8;
            int y = 3;
            
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} / {y} = {x / y} (целочисленное деление)");
            Console.WriteLine($"{x} % {y} = {x % y} (остаток от деления)");
            
            double a = 8.0;
            double b = 3.0;
            Console.WriteLine($"{a} / {b} = {a / b} (деление с плавающей точкой)");
            
            Console.WriteLine("\nИнкремент и декремент:");
            int i = 5;
            Console.WriteLine($"Начальное значение i: {i}");
            Console.WriteLine($"++i: {++i}");
            Console.WriteLine($"i++ возвращает: {i++}, после i = {i}");
            Console.WriteLine($"--i: {--i}");
            Console.WriteLine($"i-- возвращает: {i--}, после i = {i}");
        }
        
        public void LogicalOperators() {
            Console.WriteLine("\nЛогические операторы:");
            
            bool t = true;
            bool f = false;
            
            Console.WriteLine($"true && false = {t && f}");
            Console.WriteLine($"true || false = {t || f}");
            Console.WriteLine($"!true = {!t}");
            
            Console.WriteLine("\nПобитовые логические операторы:");
            int a = 5;  // 0101 в двоичной системе
            int b = 3;  // 0011 в двоичной системе
            
            Console.WriteLine($"{a} & {b} = {a & b} (0101 & 0011 = 0001 = 1)");
            Console.WriteLine($"{a} | {b} = {a | b} (0101 | 0011 = 0111 = 7)");
            Console.WriteLine($"{a} ^ {b} = {a ^ b} (0101 ^ 0011 = 0110 = 6)");
            Console.WriteLine($"~{a} = {~a} (~0101 = 1010 с учетом знакового бита)");
        }
    }
}