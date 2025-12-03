using _17_StandartInterfaces;

//Auditory auditory = new Auditory();

//Console.WriteLine(new string('+', 10) + " students list " + new string('+', 10) + "\n");
//Console.WriteLine(auditory);

//auditory.Sort(new StudentCardComparer());
//Console.WriteLine();
//Console.WriteLine(new string('+', 10) + " sorted students list " + new string('+', 10) + "\n");
//Console.WriteLine(auditory);


//StudentCard studentCard1 = new StudentCard()
//{
//    Number = 1234,
//    Series = "ABC1234"
//};

//StudentCard studentCard2 = (StudentCard)studentCard1.Clone();
//studentCard2.Number = 9999;

//Console.WriteLine(studentCard1);


//Student student1 = new Student
//{
//    FirstName = "Joey",
//    LastName = "Finch",
//    BirthDate = new DateTime(1996, 11, 30),
//    StudentCard = new StudentCard
//    {
//        Number = 258322,
//        Series = "AA"
//    }
//};

//Student student2 = (Student)student1.Clone();

//student2.FirstName = "AAAAAAAA";
//student2.StudentCard.Number = 9999;

//Console.WriteLine(student1);


Auditory auditory = new Auditory();

foreach(Student student in auditory)
{
    Console.WriteLine(student);
}