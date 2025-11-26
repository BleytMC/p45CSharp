namespace _15_Interfaces
{
    class Manager : Worker, IManager, IWorker
    {
        public void Control()
        {
            Console.WriteLine("Manager Controls");
        }

        public void Organize()
        {
            Console.WriteLine("Manager Organizes");
        }

        public void Motivate()
        {
            Console.WriteLine("Manager Motivates");
        }

        public void Plan()
        {
            Console.WriteLine("Manager Plans");
        }

        public void Work()
        {
            Console.WriteLine("Manager Works");
        }

        public void Relax()
        {
            Console.WriteLine("Manager Relaxes");
        }
    }
}
