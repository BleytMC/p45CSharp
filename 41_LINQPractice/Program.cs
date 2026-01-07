string[] cars = {
    "Nissan", "Chevrolet", "Tesla", "Cadillac", "Hummer", "Alfa Romeo", "Land Rover",
    "Chrysler", "Bentley", "Renault", "Suzuki", "Honda", "Dodge", "BMW", "Ferrari", "Audi",
    "Hyundai", "Skoda", "KIA", "Bugatti","Bentley", "SEAT", "Maserati", "Ford", "Buick", "Lexus",
    "Mercedes", "Toyota", "Lincoln", "Volvo", "Aston Martin", "Fiat", "Subaru", "Maybach",
    "Infiniti", "Volkswagen","Opel", "Citroen", "Mazda", "Jaguar", "Peugeot", "Dacia", "Jeep", "Lamborghini"
};

// Select

// 1

//var query = from car in cars select car;

//foreach(var item in query) Console.WriteLine(item);

// 2

//var query = from car in cars select car.Length;

//foreach (var item in query) Console.WriteLine(item);

// 3

//var query = from car in cars select car + "!";

//foreach (var item in query) Console.WriteLine(item);


// Where

// 1

//var query = from car in cars where car[car.Length - 1] == 'a' select car;

//foreach (var item in query) Console.WriteLine(item);

// 3

//var query = from car in cars where car.Length == 5 select car;

//foreach (var item in query) Console.WriteLine(item);

// 6

//var query = from car in cars where car.Contains('s') select car.ToUpper();

//foreach (var item in query) Console.WriteLine(item);


// orderby

// 1

//var query = from car in cars orderby car ascending select car;

//var query = from car in cars orderby car descending select car;

//foreach (var item in query) Console.WriteLine(item);

// 2

//var query = from car in cars orderby car.Length ascending select car;

//foreach (var item in query) Console.WriteLine(item);

// 3

//var query = from car in cars where car.Length > 4 orderby car ascending select car;

//var query = from car in cars where car.Length > 4 orderby car descending select car;

//foreach (var item in query) Console.WriteLine(item);


// group by

// 3

//var query = from car in cars group car by car.Length;

//foreach (var group in query)
//{
//    Console.WriteLine(group.Key);
//    foreach(string car in group) Console.WriteLine(car);
//}


// into

// 1

//var query = from car in cars group car by car[0] into res where res.Count() > 1 select res;

//foreach (var group in query)
//{
//    Console.WriteLine(group.Key);
//    foreach(string car in group) Console.WriteLine(car);
//}