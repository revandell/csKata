namespace CsKata.DesignPatterns
{
    class Prototype
    {
        public class Point
        {
            public int X, Y;
        }

        public class Line
        {
            public Point Start, End;

            public Line DeepCopy()
            {
                Point newStart = new Point() { X = Start.X, Y = Start.Y };
                Point newEnd = new Point() { X = End.X, Y = End.Y };

                return new Line() { Start = newStart, End = newEnd };
            }
        }
    }
}
