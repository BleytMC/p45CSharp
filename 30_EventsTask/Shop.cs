namespace _30_EventsTask
{
    class Shop
    {
        public void Buy(object sender, PersonEventArgs person)
        {
            if(person.Age >= 18) Console.WriteLine("Can buy this item!");
            else Console.WriteLine("Can't buy this item!");
        }
    }
}
