using _39_StandartInterfacesHM;

Bank bank = new Bank(
[
    new Account("Ivan", "Petrenko", new DateTime(1995, 3, 12), 15000),
    new Account("Olena", "Koval", new DateTime(1998, 7, 25), 8200),
    new Account("Andrii", "Shevchenko", new DateTime(2001, 1, 5), 12000),
    new Account("Maria", "Bondar", new DateTime(1999, 11, 30), 6400),
    new Account("Dmytro", "Melnyk", new DateTime(1996, 6, 18), 20000),
    new Account("Natalia", "Tkachenko", new DateTime(2002, 9, 9), 5300),
    new Account("Roman", "Kravchuk", new DateTime(1997, 4, 2), 17500)
]);

bank.Sort(new AccountBalanceCamparer());
//Console.WriteLine(bank);

foreach(Account account in bank)
{
    Console.WriteLine(account);
}