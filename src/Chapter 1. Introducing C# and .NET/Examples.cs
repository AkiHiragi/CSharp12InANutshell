namespace Chapter1
{
    // Класс с примерами из первой главы
    public static class Examples
    {
        // Пример простой программы C#
        public static void BasicProgram()
        {
            Console.WriteLine("Пример базовой программы C#");
            Console.WriteLine("C# 12 и .NET 8 - современная платформа разработки");
        }

        // Пример компиляции и выполнения
        public static void CompilationExample()
        {
            Console.WriteLine("Процесс компиляции C#:");
            Console.WriteLine("1. Исходный код (.cs) -> Компилятор C# -> IL код (.dll/.exe)");
            Console.WriteLine("2. IL код -> CLR (JIT компиляция) -> Машинный код");
            Console.WriteLine("3. Выполнение на процессоре");
        }

        // Демонстрация базовых типов .NET
        public static void DotNetTypes()
        {
            Console.WriteLine("Базовые типы .NET:");
            Console.WriteLine($"int: {typeof(int).FullName}");
            Console.WriteLine($"string: {typeof(string).FullName}");
            Console.WriteLine($"bool: {typeof(bool).FullName}");
            Console.WriteLine($"DateTime: {typeof(DateTime).FullName}");
        }
    }
}