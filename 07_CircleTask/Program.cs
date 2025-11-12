using _07_CircleTask;

Circle circle = new Circle(new Point(3, 4), 5);
Point point = new Point(10, 4);

Console.WriteLine(circle.IsPointInside(point));

double perimeter = circle.GetPerimeter();
double area = circle.GetArea();

Console.WriteLine($"Perimeter: {perimeter} | Area: {area}");