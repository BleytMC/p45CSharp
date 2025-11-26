using System.Data;

namespace _16_InterfacesTask
{
    class Line : Figure, IMove
    {
        private Point start;
        private Point end;

        public Line(ConsoleColor color, int thickness, Point start, Point end)
            :base(color, thickness)
        {
            this.start = start;
            this.end = end;
        }

        public override void Draw()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine($"Figure: Line\n\tThickness: {Thickness}\n\tStart point: {start}\n\tEnd point: {end}");
        }

        public void Up(int distance)
        {
            start.Y -= distance;
            end.Y -= distance;
        }

        public void Down(int distance)
        {
            start.Y += distance;
            end.Y += distance;
        }

        public void Right(int  distance)
        {
            start.X += distance;
            end.X += distance;
        }

        public void Left(int distance)
        {
            start.X -= distance;
            end.X -= distance;
        }
    }
}
