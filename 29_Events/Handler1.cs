namespace _29_Events
{
    class Handler1
    {
        public void Message()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Handler1: Conter has reached 50");
            Console.ResetColor();
        }
    }
}