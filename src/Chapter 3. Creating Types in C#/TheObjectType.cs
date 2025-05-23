namespace Chapter_3._Creating_Types_in_C_ {
    public class TheObjectType {
        public void BoxingAndUnboxing() {
            Console.WriteLine("=== Упаковка и распаковка (Boxing and Unboxing) ===\n");

            Console.WriteLine("Пример с целым числом:");
            int i = 3;
            object o = i;      // упаковка
            i = 5;            // изменение оригинального значения
            Console.WriteLine($"  Упакованное значение (o): {o}");
            Console.WriteLine($"  Измененное значение (i): {i}\n");

            Console.WriteLine("Пример со строкой:");
            string s = "First";
            object o2 = s;     // упаковка
            s = "Second";      // изменение оригинальной строки
            Console.WriteLine($"  Упакованное значение (o2): {o2}");
            Console.WriteLine($"  Измененное значение (s): {s}\n");

            Console.WriteLine("Заметка: При упаковке создается копия значения,");
            Console.WriteLine("поэтому изменение оригинала не влияет на упакованную версию.\n");
        }

        public void DownCasting() {
            Console.WriteLine("=== Понижающее приведение типов (Downcasting) ===\n");

            Console.WriteLine("Приведение double к int через object:");
            object o = 3.5;    // double упаковывается в object
            int i = (int)(double)o;  // необходимо сначала привести к double
            Console.WriteLine($"  Исходное значение (object): {o}");
            Console.WriteLine($"  После приведения к int: {i}\n");

            Console.WriteLine("Заметка: При понижающем приведении нужно учитывать");
            Console.WriteLine("возможную потерю данных (в данном случае дробной части).\n");
        }

        public void GetTypeMethod() {
            Console.WriteLine("=== Получение информации о типе (GetType Method) ===\n");

            Point p = new Point();
            Console.WriteLine("Работа с типом Point:");
            Console.WriteLine($"  Имя типа через GetType(): {p.GetType().Name}");
            Console.WriteLine($"  Имя типа через typeof: {typeof(Point).Name}");
            Console.WriteLine($"  Сравнение типов (p.GetType() == typeof(Point)): {p.GetType() == typeof(Point)}\n");

            Console.WriteLine("Информация о типах полей Point:");
            Console.WriteLine($"  Тип поля X: {p.X.GetType().Name}");
            Console.WriteLine($"  Полное имя типа поля Y: {p.Y.GetType().FullName}\n");

            Console.WriteLine("Заметка: GetType() возвращает тип во время выполнения,");
            Console.WriteLine("а typeof - во время компиляции.\n");
        }

        public class Point { public int X, Y; }
    }
}