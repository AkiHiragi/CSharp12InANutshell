namespace Chapter4 {
    public class NullableValueTypes {
        public void NullableTStruct() {
            Console.WriteLine("=== Nullable типы-значения ===\n");

            Console.WriteLine("Создаем nullable int со значением null:");
            int? i = null;

            Console.WriteLine($"Проверяем !i.HasValue: {!i.HasValue}");
            Console.WriteLine($"i.HasValue: {i.HasValue}");
            Console.WriteLine($"Значение по умолчанию i.GetValueOrDefault(): {i.GetValueOrDefault()}");

            Console.WriteLine("\nЗаметка: Nullable типы позволяют присваивать null типам-значениям,");
            Console.WriteLine("что особенно полезно при работе с базами данных и условными значениями.\n");
        }

        public void ImplicitAndExplicitNullableConversions() {
            Console.WriteLine("=== Неявные и явные преобразования nullable типов ===\n");

            Console.WriteLine("Неявное преобразование из int в int?:");
            int? i = 5;  // неявное преобразование из int в int?
            Console.WriteLine($"int? i = 5; // i = {i}");

            Console.WriteLine("\nЯвное преобразование из int? в int:");
            int j = (int)i;  // явное преобразование из int? в int
            Console.WriteLine($"int j = (int)i; // j = {j}");

            Console.WriteLine($"\nСравнение: i == j: {i == j}");

            Console.WriteLine("\nЗаметка: Преобразование из nullable в non-nullable требует явного приведения типов.");
            Console.WriteLine("Если nullable содержит null, явное приведение вызовет InvalidOperationException.\n");
        }

        public void BoxingAndUnboxingNullableValues() {
            Console.WriteLine("=== Упаковка и распаковка nullable типов ===\n");

            Console.WriteLine("Пример безопасного приведения с использованием as:");
            object s = "string";
            Console.WriteLine($"object s = \"{s}\";");

            Console.WriteLine("Пытаемся преобразовать строку в int?:");
            int? n = s as int?;
            Console.WriteLine($"int? n = s as int?;");

            Console.WriteLine($"Результат n.HasValue: {n.HasValue}");

            Console.WriteLine("\nПример с числом:");
            object boxedInt = 42;
            Console.WriteLine($"object boxedInt = {boxedInt};");

            int? m = boxedInt as int?;
            Console.WriteLine($"int? m = boxedInt as int?;");
            Console.WriteLine($"Результат m.HasValue: {m.HasValue}, m = {m}");

            Console.WriteLine("\nЗаметка: При упаковке Nullable<T> в object, если значение равно null,");
            Console.WriteLine("результатом будет null, иначе упаковывается само значение T.\n");
        }
    }
}