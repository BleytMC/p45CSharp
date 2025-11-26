namespace _16_InterfacesTask
{
    class Rectangle : Figure, IMove
    {
        private Point[] coordinates;

        public Rectangle(ConsoleColor color, int thickness, Point[] coordinates)
            : base(color, thickness)
        {
            this.coordinates = coordinates;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.Write($"Figure: Triangle\n\tThickness: {Thickness}\n\tCoordinates:");
            foreach (Point point in coordinates) Console.Write($"\n\t\t{point}");
            Console.WriteLine();
        }

        public void Up(int distance)
        {
            foreach (Point point in coordinates) point.Y -= distance;
        }

        public void Down(int distance)
        {
            foreach (Point point in coordinates) point.Y += distance;
        }

        public void Right(int distance)
        {
            foreach (Point point in coordinates) point.X += distance;
        }

        public void Left(int distance)
        {
            foreach (Point point in coordinates) point.X -= distance;
        }
    }
}
