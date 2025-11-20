using _10_PlaneHomework;

Plane[] planes = [
    new Plane("Boeing 737", 1998, 39, 35, 82000000.0),
    new Plane("Airbus A320", 2005, 37, 34, 98000000.0),
    new Plane("Antonov An-225", 1988, 84, 88, 300000000.0),
    new Plane("Embraer E190", 2010, 36, 29, 52000000.0),
    new Plane("Boeing 787 Dreamliner", 2015, 63, 60, 250000000.0)
];

foreach (Plane plane in planes) Console.WriteLine(plane);