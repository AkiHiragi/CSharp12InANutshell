namespace Chapter_3._Creating_Types_in_C_ {
    public class Inheritance {
        public void ShowOverrides() {
            Console.WriteLine("=== Демонстрация переопределения и сокрытия методов ===\n");

            Console.WriteLine("1. Пример с переопределением (override):");
            Console.WriteLine("   Создаем объект Overrider и вызываем Foo():");
            Overrider over = new Overrider();
            BaseClass b1 = over;
            Console.WriteLine("   Вызов через переменную типа Overrider:");
            over.Foo();
            Console.WriteLine("   Вызов через переменную типа BaseClass:");
            b1.Foo();
            Console.WriteLine();

            Console.WriteLine("2. Пример с сокрытием (new):");
            Console.WriteLine("   Создаем объект Hider и вызываем Foo():");
            Hider hider = new Hider();
            BaseClass b2 = hider;
            Console.WriteLine("   Вызов через переменную типа Hider:");
            hider.Foo();
            Console.WriteLine("   Вызов через переменную типа BaseClass:");
            b2.Foo();
            Console.WriteLine();

            Console.WriteLine("Заметка: При использовании override вызывается метод производного класса,");
            Console.WriteLine("а при использовании new - метод базового класса (если обращение через базовый тип).\n");
        }
    }

    public class BaseClass {
        public virtual void Foo() => Console.WriteLine("    BaseClass.Foo");
    }

    public class Overrider : BaseClass {
        public override void Foo() => Console.WriteLine("    Overrider.Foo");
    }

    public class Hider : BaseClass {
        public new void Foo() => Console.WriteLine("    Hider.Foo");
    }
}