using _27_DelegatesTask;

void MyForeach(Student[] students, MyAction<Student> action)
{
    foreach(Student student in students) action(student);
}

void FullNameUpper(Student student)
{
    Console.WriteLine($"\t{student.FirstName.ToUpper()}\t\t{student.LastName.ToUpper()}");
}

Student[] students = [
    new Student("Ivan", "Petrenko"),
    new Student("Olena", "Shevchenko"),
    new Student("Andrii", "Koval"),
    new Student("Maria", "Tkachenko"),
    new Student("Oleh", "Melnyk"),
    new Student("Sofiia", "Kravchenko"),
    new Student("Dmytro", "Lysenko"),
    new Student("Igor", "Polishchuk")
];

MyAction<Student> myAction = FullNameUpper;

MyForeach(students, myAction);


// Готові делегати в .NET

// Action<T>
// public delegate void Action<in T>(T obj);

// Func<T, TResult>
// public delegate TResult Func<in T, out TResult>(T arg);

// Predicate<T>
// public delegate bool Predicate<in T>(T obj);

// Comparison<T>
// public delegate int Comparison<in T>(T x, T y);