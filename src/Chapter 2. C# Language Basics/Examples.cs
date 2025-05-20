using System;

namespace Chapter2 {
    // Класс с примерами из второй главы
    public static class Examples {
        #region 2.1
        public static void Statement1() {
            int x = 12 * 30;
            Console.WriteLine(x);
        }

        public static int FeetToInches(int feet) {
            int inches = feet * 12;
            return inches;
        }

        public static void SayHello() {
            Console.WriteLine("Hello, world!");
        }
        #endregion

        #region 2.2
        public static void Statement2() {
            string message = "Hello, world!";
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);

            int x = DateTime.Now.Year;
            message = message + x.ToString();
            Console.WriteLine(message);

            bool simpleVar = false;
            if (simpleVar)
                Console.WriteLine("This will not print");

            int y = 5000;
            bool lessThanAMile = y < 5280;
            if (lessThanAMile)
                Console.WriteLine("This will print");
        }
        #endregion

        #region UnitConverter
        public static void UnitConverter() {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));
            Console.WriteLine(feetToInchesConverter.Convert(1000));

            Console.WriteLine(feetToInchesConverter.Convert(
                              milesToFeetConverter.Convert(1)));
        }
        #endregion

        #region Checked
        public static void Checked() {
            int a = 1_000_000;
            int b = 1_000_000;
            int c = unchecked(a * b);
            System.Console.WriteLine(c);
        }
        #endregion

        #region Special Float And Double Values
        public static void SpecialFloatAndDoubleValues() {
            Console.WriteLine("=== Специальные значения float и double ===\n");
            
            Console.WriteLine("Положительная бесконечность (1.0 / 0.0):");
            Console.WriteLine($"  Результат: {1.0 / 0.0}\n");
            
            Console.WriteLine("Отрицательная бесконечность (-1.0 / 0.0):");
            Console.WriteLine($"  Результат: {-1.0 / 0.0}\n");
            
            Console.WriteLine("Деление на отрицательный ноль (1.0 / -0.0):");
            Console.WriteLine($"  Результат: {1.0 / -0.0}\n");
            
            Console.WriteLine("Деление отрицательного числа на отрицательный ноль (-1.0 / -0.0):");
            Console.WriteLine($"  Результат: {-1.0 / -0.0}\n");

            Console.WriteLine("Неопределенное значение (NaN) (0.0 / 0.0):");
            Console.WriteLine($"  Результат: {0.0 / 0.0}\n");
            
            Console.WriteLine("Бесконечность минус бесконечность ((1.0 / 0.0) - (1.0 / 0.0)):");
            Console.WriteLine($"  Результат: {(1.0 / 0.0) - (1.0 / 0.0)}\n");

            Console.WriteLine("Сравнение NaN с double.NaN (0.0 / 0.0 == double.NaN):");
            Console.WriteLine($"  Результат: {0.0 / 0.0 == double.NaN} (NaN не равен ничему, даже самому себе)\n");

            Console.WriteLine("Проверка на NaN с помощью IsNaN (double.IsNaN(0.0 / 0.0)):");
            Console.WriteLine($"  Результат: {double.IsNaN(0.0 / 0.0)} (правильный способ проверки)\n");

            Console.WriteLine("Сравнение NaN с помощью object.Equals (object.Equals(0.0 / 0.0, double.NaN)):");
            Console.WriteLine($"  Результат: {object.Equals(0.0 / 0.0, double.NaN)}\n");
        }
        #endregion


    }

    public class UnitConverter {
        int ratio;

        public UnitConverter(int unitRatio) { ratio = unitRatio; }

        public int Convert(int unit) {
            return unit * ratio;
        }
    }
}