using System;

namespace Chapter2 {
    public class StringType {
        public void Equaling() {
            string a = "test";
            string b = "test";
            Console.WriteLine($"a = \"{a}\", b = \"{b}\"");
            Console.WriteLine($"a == b: {a == b}");
        }

        public void Verbalism() {
            string a1 = "\\\\server\\fileshare\\helloworld.cs";
            string a2 = @"\\server\fileshare\helloworld.cs";
            Console.WriteLine($"a1 (обычная строка): {a1}");
            Console.WriteLine($"a2 (дословная строка): {a2}");
            Console.WriteLine($"a1 == a2: {a1 == a2}");
        }

        public void Interpolation() {
            Console.WriteLine("Простая интерполяция:");
            string s = $"255 в шестнадцатеричном формате: {byte.MaxValue:X2}";
            Console.WriteLine(s);
            
            Console.WriteLine("\nИнтерполяция с условным оператором:");
            bool b = true;
            Console.WriteLine($"Ответ в двоичном формате: {(b ? 1 : 0)}");
            
            Console.WriteLine("\nМногострочная интерполяция (C# 11+):");
            string str = $"""Текущие дата и время: {DateTime.Now}""";
            Console.WriteLine(str);
            
            Console.WriteLine("\nДословная интерполяция (C# 11+):");
            Console.WriteLine($$"""{"TimeStamp" : "{{DateTime.Now}}"}""");
            
            Console.WriteLine("\nUTF-8 строковый литерал (C# 11+):");
            ReadOnlySpan<byte> utf8 = "ab→cd"u8; // Символ стрелки занимает 3 байта
            Console.WriteLine($"Длина UTF-8 строки \"ab→cd\": {utf8.Length} байт"); // 7
        }
    }
}