namespace _16_InterfacesTask
{
    abstract class Figure
    {
        public ConsoleColor Color { get; set; }
        public int Thickness { get; set; }

        abstract public void Draw();

        protected Figure(ConsoleColor color, int thickness)
        {
            Color = color;
            Thickness = thickness;
        }
    }
}
