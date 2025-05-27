using System;
using System.Collections.Generic;

namespace Chapter4 {
    public class EnumerationAndIterators {
        public void Enumeration() {
            Console.WriteLine("Базовый пример использования перечислителя (enumerator):");
            
            Console.Write("Перебор символов в строке \"beer\": ");
            using var enumerator = "beer".GetEnumerator();
            while (enumerator.MoveNext()) {
                var element = enumerator.Current;
                Console.Write(element);
            }
            Console.WriteLine();
        }

        public void CollectionInitializers() {
            Console.WriteLine("\nИнициализаторы коллекций:");
            
            Console.WriteLine("Создание и инициализация словаря:");
            var dict = new Dictionary<int, string> {
                [1] = "one",
                [2] = "two",
                [3] = "three"
            };
            
            Console.WriteLine("Перебор элементов словаря с помощью перечислителя:");
            using var enumerator = dict.GetEnumerator();
            while (enumerator.MoveNext()) {
                var kvp = enumerator.Current;
                Console.WriteLine($"Key = {kvp.Key}, Value = {kvp.Value}");
            }
        }

        public void Iterators() {
            Console.WriteLine("\nИтераторы с использованием yield return:");
            
            Console.Write("Первые 6 чисел Фибоначчи: ");
            foreach (var fib in Fibs(6)) {
                Console.Write($"{fib} ");
            }
            Console.WriteLine();
            
            // Локальная функция, возвращающая последовательность чисел Фибоначчи
            IEnumerable<int> Fibs(int fibCount) {
                for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++) {
                    yield return prevFib;
                    int newFib = prevFib + curFib;
                    prevFib = curFib;
                    curFib = newFib;
                }
            }
        }

        public void IteratorSemantics(bool breakEarly) {
            Console.WriteLine("\nСемантика итераторов и yield break:");
            
            Console.Write($"Последовательность с breakEarly={breakEarly}: ");
            foreach (var item in Foo()) {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            IEnumerable<string> Foo() {
                Console.WriteLine("  Начало выполнения итератора Foo()");
                Console.WriteLine("  Возвращаем \"One\"");
                yield return "One";
                Console.WriteLine("  Возвращаем \"Two\"");
                yield return "Two";
                if (breakEarly) {
                    Console.WriteLine("  Досрочное завершение итератора (yield break)");
                    yield break;
                }
                Console.WriteLine("  Возвращаем \"Three\"");
                yield return "Three";
                Console.WriteLine("  Завершение итератора");
            }
        }

        public void ComposingSequences() {
            Console.WriteLine("\nКомпозиция последовательностей:");
            
            Console.WriteLine("Четные числа из последовательности Фибоначчи:");
            foreach (int fib in EvenNumbersOnly(Fibs(10)))
                Console.WriteLine($"  {fib}");

            IEnumerable<int> Fibs(int fibCount) {
                Console.WriteLine("Генерация последовательности Фибоначчи:");
                for (int i = 0, prevFib = 1, curFib = 1; i < fibCount; i++) {
                    Console.WriteLine($"  Возвращаем число Фибоначчи: {prevFib}");
                    yield return prevFib;
                    int newFib = prevFib + curFib;
                    prevFib = curFib;
                    curFib = newFib;
                }
            }

            IEnumerable<int> EvenNumbersOnly(IEnumerable<int> sequence) {
                Console.WriteLine("Фильтрация четных чисел:");
                foreach (int x in sequence) {
                    if ((x % 2) == 0) {
                        Console.WriteLine($"  Найдено четное число: {x}");
                        yield return x;
                    } else {
                        Console.WriteLine($"  Пропускаем нечетное число: {x}");
                    }
                }
            }
        }
    }
}