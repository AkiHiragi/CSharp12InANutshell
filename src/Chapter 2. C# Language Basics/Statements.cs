using System;

namespace Chapter2 {
    public class Statements {
        public void SelectionStatements() {
            Console.WriteLine("Операторы выбора (if, switch):");
            
            // if-else
            Console.WriteLine("\nОператор if-else:");
            int temperature = 25;
            Console.WriteLine($"Температура: {temperature}°C");
            
            if (temperature > 30) {
                Console.WriteLine("Жарко!");
            } 
            else if (temperature > 20) {
                Console.WriteLine("Тепло");
            }
            else if (temperature > 10) {
                Console.WriteLine("Прохладно");
            }
            else {
                Console.WriteLine("Холодно!");
            }
            
            // switch
            Console.WriteLine("\nОператор switch:");
            int day = 3;
            Console.WriteLine($"День недели (номер): {day}");
            
            switch (day) {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Выходной");
                    break;
                default:
                    Console.WriteLine("Некорректный день недели");
                    break;
            }
            
            // switch expression (C# 8.0+)
            Console.WriteLine("\nВыражение switch (C# 8.0+):");
            string dayName = day switch {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 or 7 => "Выходной",
                _ => "Некорректный день недели"
            };
            Console.WriteLine($"День недели: {dayName}");
        }
        
        public void IterationStatements() {
            Console.WriteLine("\nОператоры итерации (циклы):");
            
            // while
            Console.WriteLine("\nЦикл while:");
            int i = 1;
            while (i <= 5) {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine();
            
            // do-while
            Console.WriteLine("\nЦикл do-while:");
            i = 5;
            do {
                Console.Write($"{i} ");
                i--;
            } while (i > 0);
            Console.WriteLine();
            
            // for
            Console.WriteLine("\nЦикл for:");
            for (int j = 0; j < 5; j++) {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
            
            // foreach
            Console.WriteLine("\nЦикл foreach:");
            string[] fruits = ["яблоко", "банан", "апельсин", "груша"];
            foreach (string fruit in fruits) {
                Console.Write($"{fruit} ");
            }
            Console.WriteLine();
        }
        
        public void JumpStatements() {
            Console.WriteLine("\nОператоры перехода:");
            
            // break
            Console.WriteLine("\nОператор break:");
            for (int i = 0; i < 10; i++) {
                if (i == 5) break;
                Console.Write($"{i} ");
            }
            Console.WriteLine("(цикл прерван)");
            
            // continue
            Console.WriteLine("\nОператор continue:");
            for (int i = 0; i < 10; i++) {
                if (i % 2 == 0) continue;
                Console.Write($"{i} ");
            }
            Console.WriteLine("(пропущены четные числа)");
            
            // return - демонстрируется неявно через вызов метода
            
            // goto
            Console.WriteLine("\nОператор goto:");
            int j = 1;
            
        start:
            Console.Write($"{j} ");
            j++;
            if (j <= 5) goto start;
            
            Console.WriteLine("(конец goto)");
        }
    }
}