using _18_ICoparerTask;

Bank bank = new Bank();

bank.Sort(new AccountBalanceComparer());
Console.WriteLine(bank);