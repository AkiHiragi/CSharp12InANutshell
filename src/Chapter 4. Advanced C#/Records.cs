namespace Chapter4 {
    public class Records {

    }

    record Point {
        public Point(double x, double y) => (X, Y) = (x, y);

        public double X { get; init; }
        public double Y { get; init; }

        public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);
    }
}