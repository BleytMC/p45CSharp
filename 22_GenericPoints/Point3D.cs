namespace _22_GenericPoints
{
    class Point3D<T> : Point2D<T>
    {
        public T z { get; set; }

        public Point3D()
            : base()
        {
            z = default(T);
        }

        public Point3D(T x, T y, T z)
            : base(x, y)
        {
            this.z = z;
        }

        public override string ToString()
        {
            return $"X: {x}\tY: {y}\tZ: {z}";
        }
    }
}
