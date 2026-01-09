using _43_LINQ_Practice2;

//List<Person> people = new List<Person>()
//{
//    new Person(){ Name = "Andriy", Age = 24, City = "Kyiv" },
//    new Person(){ Name = "Marta", Age = 18, City = "Madrid" },
//    new Person(){ Name = "Oleg", Age = 15, City = "London" },
//    new Person(){ Name = "Anna", Age = 55, City = "Kyiv" },
//    new Person(){ Name = "Anna", Age = 32, City = "Kyiv" }
//};

//var query1 = from p in people
//             where p.Age > 25
//             select p;

//var query2 = from p in people
//             where p.City != "Kyiv"
//             select p;

//var query3 = from p in people
//             where p.City == "Kyiv"
//             select p.Name;

//var query4 = from p in people
//             where p.Age > 35 && p.Name == "Anna"
//             select p;

//var query5 = from p in people
//             where p.City == "London"
//             select p;

////

//int maxAge = people.Max(p => p.Age);

//Console.WriteLine(maxAge);

//var query6 = from p in people
//             orderby p.Name descending
//             select new
//             {
//                 p.Name,
//                 p.Age
//             };

//foreach (var p in query6) Console.WriteLine(p);

//var theYoungest = people.First(p => p.Age == people.Min(p => p.Age));

//Console.WriteLine(theYoungest);

//var query7 = from p in people
//             group p by p.City;

//foreach (var group in query7)
//{
//    Console.WriteLine(group.Key);
//    foreach (var p in group) Console.WriteLine(p);
//}

//var query8 = from p in people
//             select new
//             {
//                 p.Name,
//                 Count = p.Name.Length
//             };

//foreach (var p in query8) Console.WriteLine(p);



List<Department> departments = new List<Department>()
{
    new Department(){ Id = 1, Country = "Ukraine", City = "Lviv" },
    new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
    new Department(){ Id = 3, Country = "France", City = "Paris" },
    new Department(){ Id = 4, Country = "Italy", City = "Rome" }
};

List<Employee> employees = new List<Employee>()
{
    new Employee()
        { Id = 1, FirstName = "Tamara", LastName = "Shevchuk", Age = 24, DepId = 2 },
    new Employee()
        { Id = 2, FirstName = "Vasyl", LastName = "Latyk", Age = 33, DepId = 1 },
    new Employee()
        { Id = 3, FirstName = "Anna", LastName = "Shevchuk ", Age = 43, DepId = 3 },
    new Employee()
        { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
    new Employee()
        { Id = 5, FirstName = "Maria", LastName = "Voron", Age = 36, DepId = 4 },
    new Employee()
        { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
    new Employee()
        { Id = 7, FirstName = "Vasyl", LastName = " Shevchuk", Age = 27, DepId = 4 }
};


// 1

var query1 = from d in departments
            join e in employees on d.Id
            equals e.DepId
            where d.Country == "Ukraine" && d.City != "Lviv"
            select new
            {
                e.FirstName,
                e.LastName
            };

Console.WriteLine("\n1");
foreach(var e in query1) Console.WriteLine(e);

// 2

var query2 = departments.Select(d => d.Country).Distinct();

Console.WriteLine("\n2");
foreach(var c in query2) Console.WriteLine(c);

// 3

var query3 = employees.Where(e => e.Age > 25).Take(3);

Console.WriteLine($"\n3");
foreach(var e in query3) Console.WriteLine(e);

// 4

var query4 = from d in departments
             join e in employees on d.Id
             equals e.DepId
             where d.City == "Kyiv" && e.Age > 23
             select new
             {
                 e.FirstName,
                 e.LastName,
                 e.Age
             };

Console.WriteLine("\n4");
foreach(var e in query4) Console.WriteLine(e);

// 5

var query5 = from d in departments
             join e in employees on d.Id
             equals e.DepId
             orderby e.Age descending
             select new
             {
                 e.Id,
                 e.FirstName,
                 e.LastName,
                 e.Age
             };

Console.WriteLine("\n5");
foreach(var e in query5) Console.WriteLine(e);