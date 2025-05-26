using System;

namespace Chapter4 {
    public class LambdaExpressions {
        public void ShowActions() {
            Console.WriteLine("Демонстрация проблемы с замыканием в цикле:");
            
            Action[] actions = new Action[3];
            for (int i = 0; i < 3; i++) {
                actions[i] = () => Console.Write(i);
            }
            
            Console.WriteLine("Вызов действий после завершения цикла:");
            foreach (Action a in actions) {
                a(); // Выведет "333" вместо "012"
            }
            Console.WriteLine(" (все действия выводят 3, так как переменная i = 3 после цикла)");
        }

        public void ShowOtherActions() {
            Console.WriteLine("\nРешение проблемы с замыканием (локальная копия переменной):");
            
            Action[] actions = new Action[3];
            for (int i = 0; i < 3; i++) {
                int loopScopedI = i; // Создаем локальную копию для каждой итерации
                actions[i] = () => Console.Write(loopScopedI);
            }
            
            Console.WriteLine("Вызов действий с локальной копией переменной:");
            foreach (Action a in actions) {
                a(); // Выведет "012" как ожидается
            }
            Console.WriteLine(" (правильный результат: 0, 1, 2)");
        }
        
        public void BasicLambdaSyntax() {
            Console.WriteLine("\nРазличные формы синтаксиса лямбда-выражений:");
            
            // Лямбда без параметров
            Action sayHello = () => Console.WriteLine("Привет, мир!");
            Console.WriteLine("Лямбда без параметров: sayHello = () => Console.WriteLine(\"Привет, мир!\")");
            sayHello();
            
            // Лямбда с одним параметром
            Func<int, int> square = x => x * x;
            Console.WriteLine("\nЛямбда с одним параметром: square = x => x * x");
            Console.WriteLine($"square(5) = {square(5)}");
            
            // Лямбда с несколькими параметрами
            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine("\nЛямбда с несколькими параметрами: add = (x, y) => x + y");
            Console.WriteLine($"add(3, 7) = {add(3, 7)}");
            
            // Лямбда с блоком кода
            Func<int, int> factorial = n => {
                int result = 1;
                for (int i = 1; i <= n; i++) {
                    result *= i;
                }
                return result;
            };
            Console.WriteLine("\nЛямбда с блоком кода: factorial = n => { ... }");
            Console.WriteLine($"factorial(5) = {factorial(5)}");
        }
        
        public void LambdaCapture() {
            Console.WriteLine("\nЗахват переменных в лямбда-выражениях:");
            
            int factor = 2;
            Func<int, int> multiplier = n => n * factor;
            
            Console.WriteLine($"factor = {factor}, multiplier(5) = {multiplier(5)}");
            
            factor = 3;
            Console.WriteLine($"После изменения: factor = {factor}, multiplier(5) = {multiplier(5)}");
            
            // Демонстрация статического локального функции (C# 9+)
            Console.WriteLine("\nСтатическая локальная функция (не захватывает переменные):");
            static int StaticMultiply(int x, int y) => x * y;
            Console.WriteLine($"StaticMultiply(4, 5) = {StaticMultiply(4, 5)}");
        }
    }
}