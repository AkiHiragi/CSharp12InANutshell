namespace Chapter_4._Advanced_C_ {
    public class Delegates {
        public void Transformer() {
            Console.WriteLine("=== Пример использования делегата ===\n");
            
            Console.WriteLine("Создаем делегат и присваиваем ему метод Square:");
            Transform t = Square;
            
            Console.WriteLine("Вызываем делегат с аргументом 3:");
            int result = t(3);
            Console.WriteLine($"Результат: {result}\n");
            
            Console.WriteLine("Заметка: Делегат - это тип, который безопасно инкапсулирует метод.");
            Console.WriteLine("Делегаты позволяют передавать методы как параметры.\n");
        }

        public void Transformer2() {
            Console.WriteLine("=== Пример передачи делегата как параметра ===\n");
            
            Console.WriteLine("Исходный массив:");
            int[] values = [1, 2, 3];
            foreach (int i in values)
                Console.Write(i + " ");
            Console.WriteLine("\n");
            
            Console.WriteLine("Применяем трансформацию Square к каждому элементу:");
            Transformer(values, Square);
            
            Console.WriteLine("Результат:");
            foreach (int i in values)
                Console.Write(i + " ");
            Console.WriteLine("\n");
            
            Console.WriteLine("Заметка: Делегаты позволяют реализовать стратегию обработки данных,");
            Console.WriteLine("которая может быть изменена во время выполнения программы.\n");
        }

        public void MulticastDelegates() {
            Console.WriteLine("=== Пример многоадресного делегата ===\n");
            
            Console.WriteLine("Создаем и комбинируем делегаты:");
            ProgressReporter p = WriteProgressToConsole;
            p += WriteProgressToFile;
            
            Console.WriteLine("Вызываем многоадресный делегат:");
            Processor(new int[] { 3, 4, 5 }, Square, p);
            
            Console.WriteLine("\nЗаметка: Многоадресные делегаты вызывают все методы в цепочке.");
            Console.WriteLine("Они особенно полезны для реализации событий.\n");
        }

        private void Transformer(int[] arr, Transform t) {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = t(arr[i]);
        }

        private void Processor(int[] values, Transform t, ProgressReporter p) {
            for (int i = 0; i < values.Length; i++) {
                values[i] = t(values[i]);
                p(i + 1, values.Length);  // Сообщаем о прогрессе
            }
        }

        private void WriteProgressToConsole(int percentComplete, int total) {
            Console.WriteLine($"  Обработано {percentComplete} из {total} элементов");
        }

        private void WriteProgressToFile(int percentComplete, int total) {
            Console.WriteLine($"  [Файл] Прогресс: {percentComplete * 100 / total}%");
        }

        private int Square(int x) => x * x;
        private int Cube(int x) => x * x * x;
    }

    delegate int Transform(int x);
    delegate void ProgressReporter(int percentComplete, int total);
}