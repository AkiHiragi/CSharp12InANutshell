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


    }

    public class UnitConverter {
        int ratio;

        public UnitConverter(int unitRatio) { ratio = unitRatio; }

        public int Convert(int unit) {
            return unit * ratio;
        }
    }
}