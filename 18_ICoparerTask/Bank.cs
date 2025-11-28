using System.Collections;

namespace _18_ICoparerTask
{
    class Bank
    {
        private Account[] accounts = [
            new Account("John", "Miller", new DateTime(1992, 4, 10), 2450.75),
            new Account("Emily", "Johnson", new DateTime(1998, 9, 23), 1870.30),
            new Account("Michael", "Anderson", new DateTime(1989, 12, 5), 3250.0),
            new Account("Sarah", "Williams", new DateTime(2000, 2, 17), 560.45),
            new Account("Daniel", "Brown", new DateTime(1995, 7, 29), 1410.9)
        ];

        public Account this[int index]
        {
            get { return accounts[index]; }
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(accounts, comparer);
        }

        public override string ToString()
        {
            return string.Join("\n", accounts.Select(x => x.ToString()));
        }
    }
}
