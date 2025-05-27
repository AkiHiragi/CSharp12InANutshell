namespace Chapter4 {
    public class ExtensionMethods {
        public void IsCapitalized() {
            Console.WriteLine("=== Методы расширения ===\n");

            Console.WriteLine("Проверяем, начинается ли строка с заглавной буквы:");
            string s = "Hello World";
            Console.WriteLine($"Строка: \"{s}\"");
            Console.WriteLine($"s.IsCapitalized(): {s.IsCapitalized()}");

            string s2 = "hello world";
            Console.WriteLine($"\nСтрока: \"{s2}\"");
            Console.WriteLine($"s2.IsCapitalized(): {s2.IsCapitalized()}");

            Console.WriteLine("\nЗаметка: Методы расширения позволяют добавлять методы к существующим типам");
            Console.WriteLine("без создания производного класса или модификации оригинального типа.\n");
        }

        public void AnonymousTypes() {
            Console.WriteLine("=== Анонимные типы ===\n");

            Console.WriteLine("Создаем анонимный тип:");
            var a1 = new { A = 1, B = 2, C = 3, D = 4, E = 5 };
            Console.WriteLine($"a1: {{ A = {a1.A}, B = {a1.B}, C = {a1.C}, D = {a1.D}, E = {a1.E} }}");

            Console.WriteLine("\nСоздаем новый экземпляр с измененным свойством E:");
            var a2 = a1 with { E = 10 };
            Console.WriteLine($"a2: {{ A = {a2.A}, B = {a2.B}, C = {a2.C}, D = {a2.D}, E = {a2.E} }}");

            Console.WriteLine("\nПроверяем равенство свойств:");
            Console.WriteLine($"a1.A == a2.A: {a1.A == a2.A}");
            Console.WriteLine($"a1.E == a2.E: {a1.E == a2.E}");

            Console.WriteLine("\nЗаметка: Анонимные типы полезны, когда нужно создать простую структуру данных");
            Console.WriteLine("без необходимости определять отдельный класс. Они неизменяемы (immutable),");
            Console.WriteLine("но с C# 9.0 поддерживают выражения with для создания новых экземпляров.\n");
        }

        public void ChainingExtensionMethods() {
            Console.WriteLine("=== Цепочки методов расширения ===\n");

            Console.WriteLine("Создаем строку и применяем цепочку методов:");
            string input = "  hello world  ";
            Console.WriteLine($"Исходная строка: \"{input}\"");

            string result = input.Trim().Capitalize().AddExclamation();
            Console.WriteLine($"После цепочки методов: \"{result}\"");

            Console.WriteLine("\nЗаметка: Методы расширения можно объединять в цепочки,");
            Console.WriteLine("что делает код более читаемым и выразительным.\n");
        }
    }

    public static class StringHelper {
        public static bool IsCapitalized(this string s) {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }

        public static string Capitalize(this string s) {
            if (string.IsNullOrEmpty(s)) return s;
            return char.ToUpper(s[0]) + s[1..];
        }

        public static string AddExclamation(this string s) {
            return s + "!";
        }
    }
}