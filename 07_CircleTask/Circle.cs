namespace _07_CircleTask
{
    internal class Circle
    {
        private int radius;
        private Point center;

        public Circle(Point center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public bool IsPointInside(Point point)
        {
            int dx = point.GetX() - center.GetX();
            int dy = point.GetY() - center.GetY();
            return Math.Pow(dx, 2) + Math.Pow(dy, 2) < Math.Pow(radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public double GetArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
