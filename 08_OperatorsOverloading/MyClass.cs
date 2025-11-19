namespace _08_OperatorsOverloading
{
    class MyClass
    {
        public int X { get; set; }
        public void Print()
        {
            Console.WriteLine($"X: {X}");
        }

        public static MyClass operator+(MyClass a, MyClass b)
        {
            return new MyClass { X = a.X + b.X };
        }

        public static MyClass operator -(MyClass a, MyClass b)
        {
            return new MyClass { X = a.X - b.X };
        }
    }
}
