using _04_Classes;

/*Student student1 = new Student();

student1.SetName("John");
student1.SetSurname("Smith");
student1.SetAge(20);

student1.Print();

Student student2 = new Student("Alice", "Johnson", 22);

student2.Print();*/

/*Bank bank1 = new Bank();
Bank bank2 = new Bank();

bank1.Deposit(2000);
bank2.Credit(3000);

Console.WriteLine(Bank.GetBalance());*/


/*void Method1(int a, int[] arr)
{
    a = 1000;
    arr = new int[] { 1, 2, 3 };
    arr[0] = 1000;
    Console.WriteLine("In Method1");
}

int a = 10;
int[] arr = { 1, 2, 3 };

Method1(a, arr);

Console.WriteLine(a);
Console.WriteLine(string.Join(" ", arr));*/


/*void Method(out int a)
{
    a = 1000;
}

int a;

Method(out a);

Console.WriteLine(a);*/

MyClass myClass = new MyClass();

myClass.Method1();
myClass.Method2();