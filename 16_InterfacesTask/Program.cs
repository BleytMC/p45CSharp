using _16_InterfacesTask;

Figure[] figures = [
    new Line(ConsoleColor.Blue, 10, new Point(5, 4), new Point(11, 4)),
    new Triangle(ConsoleColor.Red, 15, [new Point(3, 6), new Point(8, 7), new Point(4, 9)]),
    new Rectangle(ConsoleColor.Green, 7, [new Point(5, 2), new Point(8, 1), new Point(7, 5), new Point(3, 4)]),
    new Circle(ConsoleColor.Yellow, 9, new Point(4, 9), 6)
];

foreach (Figure figure in figures) figure.Draw();