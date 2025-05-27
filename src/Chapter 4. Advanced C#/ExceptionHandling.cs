using System;
using System.IO;

namespace Chapter4 {
    public class ExceptionHandling {
        public void BasicTryCatch() {
            Console.WriteLine("Базовый пример try-catch:");

            try {
                Console.WriteLine("Попытка деления на ноль:");
                int x = 10;
                int y = 0;
                Console.WriteLine($"{x} / {y} = {x / y}");
                Console.WriteLine("Этот код не будет выполнен");
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine($"Перехвачено исключение: {ex.GetType().Name}");
                Console.WriteLine($"Сообщение: {ex.Message}");
            }
            Console.WriteLine("Выполнение продолжается после обработки исключения");
        }

        public void MultipleCatchBlocks() {
            Console.WriteLine("\nПример с несколькими блоками catch:");

            try {
                Console.WriteLine("Введите 1 для создания DivideByZeroException");
                Console.WriteLine("Введите 2 для создания IndexOutOfRangeException");
                Console.WriteLine("Введите 3 для создания FormatException");
                Console.WriteLine("Введите любое другое число для продолжения без исключения");

                int choice = 1; // Для демонстрации используем фиксированное значение
                int y = 0;

                if (choice == 1) {
                    int a = 10 / y;
                }
                else if (choice == 2) {
                    int[] arr = new int[3];
                    Console.WriteLine(arr[5]);
                }
                else if (choice == 3) {
                    int.Parse("не число");
                }

                Console.WriteLine("Операция выполнена успешно");
            }
            catch (DivideByZeroException) {
                Console.WriteLine("Перехвачено исключение деления на ноль");
            }
            catch (IndexOutOfRangeException) {
                Console.WriteLine("Перехвачено исключение выхода за границы массива");
            }
            catch (FormatException) {
                Console.WriteLine("Перехвачено исключение неверного формата");
            }
            catch (Exception ex) {
                Console.WriteLine($"Перехвачено общее исключение: {ex.GetType().Name}");
            }
        }

        public void FinallyBlock() {
            Console.WriteLine("\nПример использования блока finally:");

            FileStream? file = null;
            try {
                Console.WriteLine("Попытка открыть несуществующий файл:");
                file = File.OpenRead("несуществующий_файл.txt");
                Console.WriteLine("Этот код не будет выполнен");
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Файл не найден");
            }
            finally {
                Console.WriteLine("Блок finally всегда выполняется");
                if (file != null) {
                    file.Dispose();
                    Console.WriteLine("Файл закрыт");
                }
            }

            Console.WriteLine("Демонстрация using для автоматического освобождения ресурсов:");
            try {
                using (FileStream fs = File.OpenRead("несуществующий_файл.txt")) {
                    Console.WriteLine("Чтение файла...");
                }
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Файл не найден, но ресурсы будут освобождены автоматически");
            }
        }

        public void ExceptionFilters() {
            Console.WriteLine("\nПример использования фильтров исключений (C# 6+):");

            try {
                int statusCode = 404;
                if (statusCode == 404)
                    throw new Exception("Ресурс не найден") { Data = { ["StatusCode"] = statusCode } };
                else if (statusCode == 500)
                    throw new Exception("Внутренняя ошибка сервера") { Data = { ["StatusCode"] = statusCode } };
            }
            catch (Exception ex) when (ex.Data.Contains("StatusCode") && (int)ex.Data["StatusCode"] == 404) {
                Console.WriteLine("Обработка ошибки 404: Ресурс не найден");
            }
            catch (Exception ex) when (ex.Data.Contains("StatusCode") && (int)ex.Data["StatusCode"] == 500) {
                Console.WriteLine("Обработка ошибки 500: Внутренняя ошибка сервера");
            }
            catch (Exception ex) {
                Console.WriteLine($"Обработка другой ошибки: {ex.Message}");
            }
        }
    }
}