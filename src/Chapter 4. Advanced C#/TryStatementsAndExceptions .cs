namespace Chapter4 {
    public class TryStatementsAndExceptions {
        public void FirstTry() {
            try {
                int y = Calc(0);
                Console.WriteLine(y);
            }
            catch (DivideByZeroException) {
                Console.WriteLine("x cannot be zero");
            }
            Console.WriteLine("Program completed");

            int Calc(int x) => 10 / x;
        }

        public void TheFinallyBlock() {
            StreamReader reader = null;
            try {
                reader = File.OpenText("file.txt");
                if (reader.EndOfStream) return;
                Console.WriteLine(reader.ReadToEnd());
            }
            finally {
                if (reader != null) reader.Dispose();
            }
        }
    }
}