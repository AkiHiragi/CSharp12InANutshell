using System;

namespace Chapter4 {
    public class Patterns {
        public void ConstantPattern() {
            Console.WriteLine("Демонстрация шаблона константы (constant pattern):");
            
            object o = 3;
            Console.WriteLine($"Объект o = {o} (тип: {o.GetType().Name})");
            
            Console.WriteLine("\nТрадиционный способ проверки:");
            if (o is int && (int)o == 3) {
                Console.WriteLine("o is int && (int)o == 3: Вы абсолютно правы");
            }
            
            Console.WriteLine("\nИспользование метода Equals:");
            if (3.Equals(o)) {
                Console.WriteLine("3.Equals(o): Вы абсолютно правы снова");
            }
            
            Console.WriteLine("\nИспользование шаблона константы (C# 7+):");
            if (o is 3) {
                Console.WriteLine("o is 3: Вы абсолютно правы в третий раз");
            }
        }

        public void RelationalPatterns(decimal bmi) {
            Console.WriteLine("\nДемонстрация реляционных шаблонов (relational patterns):");
            
            Console.WriteLine($"ИМТ (индекс массы тела): {bmi}");
            Console.WriteLine($"Категория веса: {GetWeightCategory(bmi)}");
            
            Console.WriteLine("\nРеализация с использованием реляционных шаблонов (C# 9+):");
            Console.WriteLine("string GetWeightCategory(decimal bmi) => bmi switch {");
            Console.WriteLine("    < 18.5m => \"underweight\",");
            Console.WriteLine("    < 25m => \"normal\",");
            Console.WriteLine("    < 30m => \"overweight\",");
            Console.WriteLine("    _ => \"obese\"");
            Console.WriteLine("};");
            
            string GetWeightCategory(decimal bmi) => bmi switch {
                < 18.5m => "underweight",
                < 25m => "normal",
                < 30m => "overweight",
                _ => "obese"
            };
        }

        public void VarPattern(string name) {
            Console.WriteLine("\nДемонстрация шаблона var (var pattern):");
            
            Console.WriteLine($"Имя для проверки: \"{name}\"");
            Console.WriteLine($"Результат проверки IsJanetOrJane: {IsJanetOrJane(name)}");
            
            Console.WriteLine("\nРеализация с использованием шаблона var:");
            Console.WriteLine("bool IsJanetOrJane(string name)");
            Console.WriteLine("    => name.ToUpper() is var upper && (upper == \"JANE\" || upper == \"JANET\");");
            
            bool IsJanetOrJane(string name)
                => name.ToUpper() is var upper && (upper == "JANE" || upper == "JANET");
        }

        public void TupleAndPositionalPatterns() {
            Console.WriteLine("\nДемонстрация шаблонов кортежей и позиционных шаблонов:");
            
            var o = (2, 3);
            Console.WriteLine($"Кортеж o = {o}");
            Console.WriteLine($"o is (2, 3): {o is (2, 3)}");
            
            Console.WriteLine("\nИспользование шаблонов кортежей в switch expression:");
            foreach (Season season in Enum.GetValues(typeof(Season))) {
                Console.WriteLine($"Средняя температура весной днем: {AverageCelsiusTemperature(Season.Spring, true)}°C");
                Console.WriteLine($"Средняя температура весной ночью: {AverageCelsiusTemperature(Season.Spring, false)}°C");
                Console.WriteLine($"Средняя температура летом днем: {AverageCelsiusTemperature(Season.Summer, true)}°C");
                Console.WriteLine($"Средняя температура зимой ночью: {AverageCelsiusTemperature(Season.Winter, false)}°C");
                break; // Показываем только несколько примеров
            }
            
            Console.WriteLine("\nРеализация с использованием шаблонов кортежей:");
            Console.WriteLine("int AverageCelsiusTemperature(Season season, bool daytime) =>");
            Console.WriteLine("(season, daytime) switch {");
            Console.WriteLine("    (Season.Spring, true) => 20,");
            Console.WriteLine("    (Season.Spring, false) => 16,");
            Console.WriteLine("    ...");
            Console.WriteLine("};");

            int AverageCelsiusTemperature(Season season, bool daytime) =>
            (season, daytime) switch {
                (Season.Spring, true) => 20,
                (Season.Spring, false) => 16,
                (Season.Summer, true) => 27,
                (Season.Summer, false) => 22,
                (Season.Fall, true) => 18,
                (Season.Fall, false) => 12,
                (Season.Winter, true) => 10,
                (Season.Winter, false) => -2,
                _ => throw new Exception("Unexpected combination"),
            };
        }

        public void PropertyPatterns(Uri uri) {
            Console.WriteLine("\nДемонстрация шаблонов свойств (property patterns):");
            
            Console.WriteLine($"URI для проверки: {uri}");
            Console.WriteLine($"Результат проверки ShouldAllow: {ShouldAllow(uri)}");
            
            Console.WriteLine("\nРеализация с использованием шаблонов свойств:");
            Console.WriteLine("bool ShouldAllow(Uri uri) =>");
            Console.WriteLine("    uri switch {");
            Console.WriteLine("        { Scheme: \"http\", Port: 80, Host: var host } => host.Length < 1000,");
            Console.WriteLine("        { Scheme: \"https\", Port: 443 } => true,");
            Console.WriteLine("        { Scheme: \"ftp\", Port: 21 } => true,");
            Console.WriteLine("        { IsLoopback: true } => true,");
            Console.WriteLine("        _ => false");
            Console.WriteLine("    };");

            bool ShouldAllow(Uri uri) =>
                uri switch {
                    { Scheme: "http", Port: 80, Host: var host } => host.Length < 1000,
                    { Scheme: "https", Port: 443 } => true,
                    { Scheme: "ftp", Port: 21 } => true,
                    { IsLoopback: true } => true,
                    _ => false
                };
        }

        public void ListPatterns() {
            Console.WriteLine("\nДемонстрация шаблонов списков (list patterns, C# 11+):");
            
            int[] numbers = { 0, 1, 2, 3, 4 };
            Console.WriteLine($"Массив чисел: [{string.Join(", ", numbers)}]");
            
            Console.WriteLine("\nПроверка на соответствие шаблону [0, 1, _, _, 4]:");
            Console.WriteLine($"numbers is [0, 1, _, _, 4]: {numbers is [0, 1, _, _, 4]}");
            
            Console.WriteLine("\nПроверка с захватом значения:");
            Console.WriteLine($"numbers is [0, 1, var x, 3, 4] && x > 1: {numbers is [0, 1, var x, 3, 4] && x > 1}");
            
            Console.WriteLine("\nИспользование slice pattern (..):");
            Console.WriteLine($"numbers is [0, .. var mid, 4] && mid.Contains(3): {numbers is [0, .. var mid, 4] && mid.Contains(3)}");
            
            if (numbers is [0, .. var middle, 4]) {
                Console.WriteLine($"Значение middle: [{string.Join(", ", middle)}]");
            }
        }

        enum Season { Spring, Summer, Fall, Winter };
    }
}