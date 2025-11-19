using _08_OperatorsOverloading;

/*MyClass obj1 = new MyClass { X = 4 };
MyClass obj2 = new MyClass { X = 3 };

MyClass obj3 = obj1 +  obj2;
obj3.Print();

obj1 += obj2;
obj1.Print();*/


/*MyArray myArray = new MyArray() { Arr = [ 4, 7, 1, 0, 5, 1 ] };
myArray.Print();

Console.WriteLine(myArray.Length);
myArray[2] = 1000;
myArray.Print();*/


/*Student student = new Student() { Name = "John", Age = 30 };

Console.WriteLine(student);*/


//Group group = new Group(new Student[]
//{
//    new Student {Name = "John", Age = 20},
//    new Student {Name = "Den", Age = 25},
//    new Student {Name = "Jack", Age = 21}
//});


//Student[] students = new Student[]
//{
//    new Student {Name = "John", Age = 20},
//    new Student {Name = "Den", Age = 25},
//    new Student {Name = "Jack", Age = 21}
//};

//string[] studentsStr = students.Select(s => s.ToString() + "\n").ToArray();
//Console.WriteLine(string.Join("", studentsStr));


Group group = new Group(new Student[]
{
    new Student {Name = "John", Age = 20},
    new Student {Name = "Den", Age = 25},
    new Student {Name = "Jack", Age = 21}
});

//Console.WriteLine(group);
//Console.WriteLine(group["Den"]);