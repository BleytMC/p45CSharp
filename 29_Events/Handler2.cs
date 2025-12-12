namespace _29_Events
{
    class Handler2
    {
        public void Message()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Handler2: Conter has reached 50");
            Console.ResetColor();
        }
    }
}