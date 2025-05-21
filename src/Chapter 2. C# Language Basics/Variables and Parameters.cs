using System.Text;

namespace Chapter_2._C__Language_Basics {
    public class VariablesAndParameters {
        public void FooSB() {
            StringBuilder sb = new StringBuilder();
            Foo(sb);
            Console.WriteLine(sb.ToString());

            void Foo(StringBuilder sb) {
                sb.Append("test");
                sb = null;
            }
        }

    }
}