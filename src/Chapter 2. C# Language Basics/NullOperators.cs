using System;

namespace Chapter2 {
    public class NullOperators {
        public void NullConditionalOperator() {
            Console.WriteLine("Оператор условного null (?.):");
            
            string? name = "John";
            Console.WriteLine($"name = \"{name}\"");
            Console.WriteLine($"name?.Length: {name?.Length}");
            
            name = null;
            Console.WriteLine($"name = {name}");
            Console.WriteLine($"name?.Length: {name?.Length}");
            
            // Использование с индексатором
            string?[] names = ["John", null, "Mary"];
            Console.WriteLine("\nМассив строк с null-значениями:");
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine($"names[{i}]?.Length: {names[i]?.Length}");
            }
        }
        
        public void NullCoalescingOperator() {
            Console.WriteLine("\nОператор объединения со значением null (??):");
            
            string? name = null;
            string displayName = name ?? "Неизвестно";
            Console.WriteLine($"name = {name}");
            Console.WriteLine($"displayName = name ?? \"Неизвестно\": {displayName}");
            
            name = "John";
            displayName = name ?? "Неизвестно";
            Console.WriteLine($"name = {name}");
            Console.WriteLine($"displayName = name ?? \"Неизвестно\": {displayName}");
            
            // Оператор присваивания с объединением со значением null (??=)
            Console.WriteLine("\nОператор присваивания с объединением со значением null (??=):");
            string? message = null;
            Console.WriteLine($"message = {message}");
            message ??= "Значение по умолчанию";
            Console.WriteLine($"После message ??= \"Значение по умолчанию\": {message}");
            
            message ??= "Новое значение";
            Console.WriteLine($"После повторного message ??= \"Новое значение\": {message}");
        }
    }
}