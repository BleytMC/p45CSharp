namespace _15_Interfaces
{
    class MyClass : Interface1, Interface2
    {
        void Interface1.Method()
        {
            Console.WriteLine("Interface1 Method");
        }

        void Interface2.Method()
        {
            Console.WriteLine("Interface2 Method");
        }
    }
}
