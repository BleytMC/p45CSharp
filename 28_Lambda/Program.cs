using _28_Lambda;

//MyDelegate myDelegate = delegate (int a, int b) { return a + b; };

//int res = myDelegate(3, 4);
//Console.WriteLine(res);

// Лямбда-оператор

//MyDelegate myDelegate = (int a, int b) => { return a + b; };

//int res = myDelegate(3, 4);
//Console.WriteLine(res);

// Лямбда-вираз

MyDelegate myDelegate = (a, b) => a + b;

int res = myDelegate(3, 4);
Console.WriteLine(res);