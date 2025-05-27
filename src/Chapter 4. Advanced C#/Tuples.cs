namespace Chapter4 {
    public class Tuples {
        public void TuplesDemonstration() {
            Console.WriteLine("=== Кортежи (Tuples) в C# ===\n");
            
            Console.WriteLine("Создаем кортеж с именем и возрастом:");
            var bob = ("Bob", 23);
            Console.WriteLine($"bob: {bob}");
            
            Console.WriteLine("\nКопируем кортеж и изменяем первый элемент:");
            var joe = bob;
            joe.Item1 = "Joe";
            
            Console.WriteLine("Результаты после изменения:");
            Console.WriteLine($"bob: {bob}");
            Console.WriteLine($"joe: {joe}");
            
            Console.WriteLine("\nЗаметка: Кортежи - это типы-значения, поэтому при копировании");
            Console.WriteLine("создается новый экземпляр, а не ссылка на существующий.\n");
        }

        public void DeconstructingTuples() {
            Console.WriteLine("=== Деконструкция кортежей ===\n");
            
            Console.WriteLine("Создаем кортеж:");
            var bob = ("Bob", 23);
            Console.WriteLine($"bob: {bob}");
            
            Console.WriteLine("\nДеконструируем кортеж в отдельные переменные:");
            var (name, age) = bob;
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age}");
            
            Console.WriteLine("\nЗаметка: Деконструкция позволяет извлечь элементы кортежа");
            Console.WriteLine("в отдельные переменные одной операцией.\n");
        }
        
        public void NamedTuples() {
            Console.WriteLine("=== Именованные кортежи ===\n");
            
            Console.WriteLine("Создаем именованный кортеж:");
            var person = (name: "Alice", age: 30, city: "New York");
            
            Console.WriteLine("Доступ к элементам по именам:");
            Console.WriteLine($"Имя: {person.name}");
            Console.WriteLine($"Возраст: {person.age}");
            Console.WriteLine($"Город: {person.city}");
            
            Console.WriteLine("\nДоступ к элементам по индексам (не рекомендуется):");
            Console.WriteLine($"Имя: {person.Item1}");
            Console.WriteLine($"Возраст: {person.Item2}");
            Console.WriteLine($"Город: {person.Item3}");
            
            Console.WriteLine("\nЗаметка: Именованные кортежи делают код более читаемым,");
            Console.WriteLine("так как позволяют обращаться к элементам по осмысленным именам.\n");
        }
        
        public void TuplesAsReturnValues() {
            Console.WriteLine("=== Кортежи как возвращаемые значения ===\n");
            
            Console.WriteLine("Вызываем метод, возвращающий кортеж:");
            var stats = GetStatistics(new[] { 1, 2, 3, 4, 5 });
            
            Console.WriteLine($"Сумма: {stats.sum}");
            Console.WriteLine($"Среднее: {stats.average}");
            Console.WriteLine($"Минимум: {stats.min}");
            Console.WriteLine($"Максимум: {stats.max}");
            
            Console.WriteLine("\nЗаметка: Кортежи удобны для возврата нескольких значений из метода");
            Console.WriteLine("без необходимости создавать специальный класс.\n");
        }
        
        private (int sum, double average, int min, int max) GetStatistics(int[] numbers) {
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            
            foreach (var n in numbers) {
                sum += n;
                min = Math.Min(min, n);
                max = Math.Max(max, n);
            }
            
            double average = (double)sum / numbers.Length;
            return (sum, average, min, max);
        }
    }
}