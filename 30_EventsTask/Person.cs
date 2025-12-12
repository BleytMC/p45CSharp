namespace _30_EventsTask
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public EventHandler<PersonEventArgs> purchaseEvent;
        public void Buy()
        {
            purchaseEvent?.Invoke(this, new PersonEventArgs { Age = this.Age});
        }
    }
}
