namespace _15_Interfaces
{
    class Scientist : Worker, IScientist, IWorker
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
            Console.WriteLine("Scientist Works");
        }

        public void Relax()
        {
            Console.WriteLine("Scientist Relaxes");
        }
    }
}
