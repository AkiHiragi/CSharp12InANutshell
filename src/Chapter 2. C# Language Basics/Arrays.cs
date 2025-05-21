using System;

namespace Chapter2 {
    public class Arrays {
        public void IndicesAndRanges() {
            Console.WriteLine("Демонстрация индексов и диапазонов:");
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine($"Исходный массив: {string.Join(", ", vowels)}");
            
            char lastElement = vowels[^1];
            char secondToLast = vowels[^2];
            Console.WriteLine($"Последний элемент (vowels[^1]): {lastElement}");
            Console.WriteLine($"Предпоследний элемент (vowels[^2]): {secondToLast}");

            Index first = 0;
            Index last = ^1;
            char firstElement = vowels[first];
            char newLastElement = vowels[last];
            Console.WriteLine($"Первый элемент (vowels[0]): {firstElement}");
            Console.WriteLine($"Последний элемент (vowels[^1]): {newLastElement}");

            Console.WriteLine("\nДиапазоны (Ranges):");
            char[] firstTwo = vowels[..2];
            char[] lastThree = vowels[2..];
            char[] middleOne = vowels[2..3];
            char[] lastTwo = vowels[^2..];
            Console.WriteLine($"Первые два (vowels[..2]): {string.Join(", ", firstTwo)}");
            Console.WriteLine($"Последние три (vowels[2..]): {string.Join(", ", lastThree)}");
            Console.WriteLine($"Средний элемент (vowels[2..3]): {string.Join(", ", middleOne)}");
            Console.WriteLine($"Последние два (vowels[^2..]): {string.Join(", ", lastTwo)}");
        }

        public void MultiDimensionalArray() {
            Console.WriteLine("\nМногомерные массивы:");
            Console.WriteLine("Прямоугольный массив 3x3:");
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = i * 3 + j;
                }
            }
            
            for (int i = 0; i < matrix.GetLength(0); i++) {
                Console.Write("[");
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write($"{matrix[i, j],2}" + (j < matrix.GetLength(1) - 1 ? ", " : ""));
                }
                Console.WriteLine("]");
            }

            Console.WriteLine("\nЗубчатый массив (jagged array):");
            int[][] jaggedMatrix = [[0, 1, 2], [3, 4, 5], [6, 7, 8, 9]];
            
            for (int i = 0; i < jaggedMatrix.Length; i++) {
                Console.Write($"Строка {i}: [");
                for (int j = 0; j < jaggedMatrix[i].Length; j++) {
                    Console.Write(jaggedMatrix[i][j] + (j < jaggedMatrix[i].Length - 1 ? ", " : ""));
                }
                Console.WriteLine("]");
            }
        }
    }
}