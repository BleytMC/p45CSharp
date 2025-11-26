namespace _15_Interfaces
{
    class Teacher : Worker, IScientist, IWorker
    {
        public void Investigate()
        {
            Console.WriteLine("Scientist Investigates");
        }

        public void Research()
        {
            Console.WriteLine("Scientist Researches");
        }

        public void Work()
        {
            Console.WriteLine("Teacher Works");
        }

        public void Relax()
        {
            Console.WriteLine("Teacher Relaxes");
        }
    }
}
