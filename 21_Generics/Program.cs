using _21_Generics;

MyClass<int> myClass = new MyClass<int>(100);
Console.WriteLine(myClass);

MyClass<string> myClass2 = new MyClass<string>("hello");
Console.WriteLine(myClass2);

MyClass<string> myClass3 = new MyClass<string>();
Console.WriteLine(myClass3);


List<int> list1 = new List<int>();
List<string> list2 = new List<string>();