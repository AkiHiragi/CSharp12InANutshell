using System;
using System.Dynamic;

namespace Chapter4 {
    public class DynamicBinding {
        public void CustomBinding() {
            Console.WriteLine("Демонстрация пользовательской динамической привязки:");
            Console.WriteLine("Создаем экземпляр класса Duck, реализующего DynamicObject:");
            
            dynamic d = new Duck();
            Console.WriteLine("Вызываем d.Quack() на динамическом объекте:");
            d.Quack();
            
            Console.WriteLine("Вызываем d.Waddle() на динамическом объекте:");
            d.Waddle();
            
            Console.WriteLine("\nОбратите внимание: класс Duck не имеет методов Quack и Waddle,");
            Console.WriteLine("но благодаря переопределению TryInvokeMember вызовы перехватываются.");
        }

        public void LanguageBinding() {
            Console.WriteLine("\nДемонстрация динамической привязки в языке C#:");
            
            int x = 3, y = 4;
            Console.WriteLine($"Вычисляем среднее значение для чисел {x} и {y}:");
            Console.WriteLine($"Mean({x}, {y}) = {Mean(x, y)}");
            
            Console.WriteLine("\nТеперь вычисляем среднее для разных типов:");
            Console.WriteLine($"Mean(1, 2, 3, 4, 5) = {Mean(1, 2, 3, 4, 5)}");
            Console.WriteLine($"Mean(1.5, 2.5, 3.5) = {Mean(1.5, 2.5, 3.5)}");
            
            Console.WriteLine("\nОпределение метода Mean с динамическими параметрами:");
            Console.WriteLine("dynamic Mean(params dynamic[] objs) {");
            Console.WriteLine("    var sum = 0;");
            Console.WriteLine("    foreach (var obj in objs) {");
            Console.WriteLine("        sum += obj;  // Динамическое сложение");
            Console.WriteLine("    }");
            Console.WriteLine("    return sum / objs.Length;  // Динамическое деление");
            Console.WriteLine("}");

            dynamic Mean(params dynamic[] objs) {
                var sum = 0;
                foreach (var obj in objs) {
                    sum += obj;
                }
                return sum / objs.Length;
            }
        }

        public void RuntimeBinderException() {
            Console.WriteLine("\nДемонстрация исключений при динамической привязке:");
            
            try {
                Console.WriteLine("Пытаемся вызвать несуществующий метод Hello() на строке:");
                Console.WriteLine("dynamic d = \"Hello\";");
                Console.WriteLine("d.Hello();  // Этот метод не существует у строк");
                
                dynamic d = "Hello";
                d.Hello();
            }
            catch (Exception e) {
                Console.WriteLine("\nПолучено исключение:");
                Console.WriteLine($"Тип исключения: {e.GetType().Name}");
                Console.WriteLine($"Сообщение: {e.Message}");
                Console.WriteLine("\nЭто происходит потому, что привязка проверяется во время выполнения,");
                Console.WriteLine("а не во время компиляции, как с обычными статическими типами.");
            }
        }

        public void RuntimeRepresentationOfDynamic() {
            Console.WriteLine("\nПредставление dynamic во время выполнения:");
            
            Console.WriteLine("Сравнение типов List<dynamic> и List<object>:");
            Console.WriteLine($"typeof(List<dynamic>) == typeof(List<object>): {typeof(List<dynamic>) == typeof(List<object>)}");
            Console.WriteLine("Это показывает, что dynamic - это не отдельный тип, а директива для компилятора.");
            
            Console.WriteLine("\nПроверка фактического типа динамической переменной:");
            dynamic x = "Hello";
            Console.WriteLine($"x = \"{x}\"");
            Console.WriteLine($"x.GetType().Name: {x.GetType().Name}");
            
            x = 123;
            Console.WriteLine($"После присваивания: x = {x}");
            Console.WriteLine($"x.GetType().Name: {x.GetType().Name}");
            
            Console.WriteLine("\nЭто демонстрирует, что dynamic - это просто отложенная проверка типа,");
            Console.WriteLine("а фактический тип определяется значением во время выполнения.");
        }
    }

    public class Duck : DynamicObject {
        public override bool TryInvokeMember(InvokeMemberBinder binder, object?[]? args, out object? result) {
            Console.WriteLine($"Метод {binder.Name}() был вызван");
            result = null;
            return true;
        }
    }
}