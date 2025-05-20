using System;

namespace Chapter3 {
    // Пример класса
    public class Person {
        // Поля
        private string _name;
        private int _age;

        // Свойства
        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public int Age {
            get { return _age; }
            set { _age = value >= 0 ? value : 0; }
        }

        // Автосвойство с инициализатором (C# 6+)
        public string Country { get; set; } = "Не указано";

        // Конструкторы
        public Person() {
            _name = "Неизвестно";
            _age = 0;
        }

        public Person(string name, int age) {
            _name = name;
            _age = age >= 0 ? age : 0;
        }

        // Методы
        public void Introduce() {
            Console.WriteLine($"Привет! Меня зовут {_name}, мне {_age} лет. Я из страны {Country}.");
        }

        public void CelebrateBirthday() {
            _age++;
            Console.WriteLine($"{_name} отмечает день рождения! Теперь возраст: {_age}");
        }
    }

    // Пример структуры
    public struct Point {
        public int X;
        public int Y;

        public Point(int x, int y) {
            X = x;
            Y = y;
        }

        public double DistanceFromOrigin() {
            return Math.Sqrt(X * X + Y * Y);
        }

        public override string ToString() {
            return $"({X}, {Y})";
        }
    }

    // Пример перечисления
    public enum DayOfWeek {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    // Класс с примерами
    public static class Examples {
        // Демонстрация работы с классами
        public static void ClassExample() {
            Console.WriteLine("Создание и использование классов:");

            var person1 = new Person();
            person1.Introduce();

            var person2 = new Person("Иван", 30);
            person2.Country = "Россия";
            person2.Introduce();
            person2.CelebrateBirthday();
        }

        // Демонстрация работы со структурами
        public static void StructExample() {
            Console.WriteLine("\nСоздание и использование структур:");

            var point1 = new Point(3, 4);
            Console.WriteLine($"Точка: {point1}");
            Console.WriteLine($"Расстояние от начала координат: {point1.DistanceFromOrigin()}");

            // Демонстрация отличия от классов (значимый тип)
            var point2 = point1;
            point2.X = 7;
            Console.WriteLine($"point1: {point1}, point2: {point2}");
        }

        // Демонстрация работы с перечислениями
        public static void EnumExample() {
            Console.WriteLine("\nИспользование перечислений:");

            var today = DayOfWeek.Wednesday;
            Console.WriteLine($"Сегодня: {today}");
            Console.WriteLine($"Порядковый номер: {(int)today}");

            // Преобразование из числа в перечисление
            int dayNumber = 5;
            var day = (DayOfWeek)dayNumber;
            Console.WriteLine($"День с номером {dayNumber}: {day}");
        }
    }
}