using System;

namespace Chapter_6._NET_Fundamentals {
    public class StringAndTextHandling {
        public void CharShow() {
            Console.WriteLine("Демонстрация работы с типом char:");

            // Преобразование регистра
            char c = 'c';
            Console.WriteLine($"char.ToUpper('{c}') = '{char.ToUpper(c)}'");
            Console.WriteLine($"char.ToUpperInvariant('{c}') = '{char.ToUpperInvariant(c)}'");

            // Проверка категорий символов
            Console.WriteLine($"char.IsWhiteSpace('\\t') = {char.IsWhiteSpace('\t')}");
            Console.WriteLine($"char.IsLetter('A') = {char.IsLetter('A')}");
            Console.WriteLine($"char.IsDigit('5') = {char.IsDigit('5')}");
            Console.WriteLine($"char.IsPunctuation('.') = {char.IsPunctuation('.')}");
            Console.WriteLine($"char.IsSymbol('+') = {char.IsSymbol('+')}");

            // Работа с числовыми значениями
            Console.WriteLine($"(int)'A' = {(int)'A'} (код символа в Unicode)");
            Console.WriteLine($"char.GetNumericValue('7') = {char.GetNumericValue('7')}");

            // Преобразования
            Console.WriteLine($"char.ConvertFromUtf32(0x1F600) = {char.ConvertFromUtf32(0x1F600)} (смайлик)");

            // Сравнение символов
            Console.WriteLine($"'a' == 'A' = {'a' == 'A'}");
            Console.WriteLine($"char.ToUpper('a') == char.ToUpper('A') = {char.ToUpper('a') == char.ToUpper('A')}");
        }

        public void StringShow() {
            Console.WriteLine("Демонстрация работы с типом string:");

            // Создание строк
            string s1 = "Hello";
            string s2 = "World";
            string s3 = s1 + " " + s2;
            Console.WriteLine($"s3 = \"{s3}\"");

            // Сравнение строк
            Console.WriteLine($"s1 == s2 = {s1 == s2}");
            Console.WriteLine($"s1.Equals(s2) = {s1.Equals(s2)}");

            // Индексация и подстроки
            Console.WriteLine($"s3[0] = '{s3[0]}'");
            Console.WriteLine($"s3.Substring(6) = \"{s3.Substring(6)}\"");

            // Работа с форматированием
            string formatted = string.Format("The {0} is in the {1}", "moon", "sky");
            Console.WriteLine($"formatted = \"{formatted}\"");

            // Работа с пустой строкой и null
            string empty = "";
            string nullString = null;
            Console.WriteLine($"string.IsNullOrEmpty(empty) = {string.IsNullOrEmpty(empty)}");
            Console.WriteLine($"string.IsNullOrEmpty(nullString) = {string.IsNullOrEmpty(nullString)}");
        }
    }
}