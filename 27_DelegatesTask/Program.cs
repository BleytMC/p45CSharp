using _27_DelegatesTask;

void MyForeach(Student[] students, MyAction<Student> action)
{
    foreach(Student student in students) action(student);
}

void FullNameUpper(Student student)
{
    Console.WriteLine($"\t{student.FirstName.ToUpper()}\t\t{student.LastName.ToUpper()}");
}

void MyFindAll(int[] arr, MyPredicate<int> predicate)
{
    foreach(int i in arr) if(predicate(i)) Console.Write($"{i} ");
    Console.WriteLine();
}

bool OnlyEven(int i)
{
    return i % 2 == 0;
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

int[] arr = { 42, 7, 89, 15, 63, 0, 100, 28, 54, 91 };

MyPredicate<int> myPredicate = OnlyEven;

MyFindAll(arr, myPredicate);