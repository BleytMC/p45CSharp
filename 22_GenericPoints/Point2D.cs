namespace _22_GenericPoints
{
    class Point2D<T>
    {
        public T x { get; set; }
        public T y { get; set; }

        public Point2D()
        {
            x = default(T);
            y = default(T);
        }

        public Point2D(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"X: {x}\tY: {y}";
        }
    }
}
