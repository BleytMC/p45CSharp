// Делегати - це об'єкти, які посилаються на методи і за допомогою яких можна ці методи викликати

// - для передачі методів, як параметри інших методів
// - є основою для подій і зворотних викликів


using _26_Delegates;
using System.Numerics;

//MyClass myClass = new MyClass();

//MyDelegate del = new MyDelegate(myClass.Method);

//del();

//del = myClass.AnotherMethod;

//del();


//Messanger messanger = new Messanger();
//MessageDelegate messageDelegate = messanger.PrintMessage;

//messageDelegate("Hello World!");



// Example 2


//Person[] peopleArray =
//[
//    new Person("Hannah", 21),
//    new Person("Edward", 52),
//    new Person("Charlie", 45),
//    new Person("Ivy", 49),
//    new Person("Alice", 25),
//    new Person("George", 65),
//    new Person("Jack", 33),
//    new Person("Diana", 19),
//    new Person("Fiona", 38),
//    new Person("Bob", 30)
//];

////foreach (Person person in peopleArray) Console.WriteLine(person);

//void SortPeople(Person[] people, MyComparerDelegate comparer)
//{
//    int n = people.Length;
//    bool swapped;

//    for (int i = 0; i < n - 1; i++)
//    {
//        swapped = false;

//        for (int j = 0; j < n - 1 - i; j++)
//        {
//            if (comparer(people[j], people[j + 1]))
//            {
//                Person temp = people[j];
//                people[j] = people[j + 1];
//                people[j + 1] = temp;

//                swapped = true;
//            }
//        }

//        if (swapped == false)
//        {
//            break;
//        }
//    }
//}

//bool CompareByAge(Person p1, Person p2)
//{
//    return p1.Age > p2.Age;
//}

//bool CompareByName(Person p1, Person p2)
//{
//    return p1.Name.CompareTo(p2.Name) == -1;
//}

//SortPeople(peopleArray, CompareByName);
//foreach (Person person in peopleArray) Console.WriteLine(person);



// Example 3

//MyClass myClass = new MyClass();

//MyDelegate del = myClass.Method;

//del += myClass.AnotherMethod;

//del -= myClass.Method;

//del();


// Example 4 (Generic Delegates)


int Add(int a, int b)
{
    return a + b;
}

int Multiply(int a, int b)
{
    return a * b;
}

double AddDouble(double a, double b)
{
    return a + b;
}

string AddString(string a, string b)
{
    return a + b;
}

//OperationDelegate<double> operationDelegate = AddDouble;

//double res = operationDelegate(4.1, 5.1);
//Console.WriteLine(res);

OperationDelegate<string> operationDelegate = AddString;

string res = operationDelegate("Hello", " World");
Console.WriteLine(res);