using _30_EventsTask;

Shop shop = new Shop();

Person person = new Person { Name = "John", Age = 20 };

PersonEventArgs personEventArgs = new PersonEventArgs();

person.purchaseEvent += shop.Buy;

person.Buy();