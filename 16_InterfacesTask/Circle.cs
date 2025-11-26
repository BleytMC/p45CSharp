namespace _16_InterfacesTask
{
    class Circle : Figure, IMove
    {
        private Point center;
        private double radius;

        public Circle(ConsoleColor color, int thickness, Point center, double radius)
            :base(color, thickness)
        {
            this.center = center;
            this.radius = radius;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Figure: Circle\n\tThickness: {Thickness}\n\tCenter: {center}\n\tRadius: {radius}");
        }

        public void Up(int distance)
        {
            center.Y -= distance;
        }

        public void Down(int distance)
        {
            center.Y += distance;
        }

        public void Right(int distance)
        {
            center.X += distance;
        }

        public void Left(int distance)
        {
            center.X -= distance;
        }
    }
}
