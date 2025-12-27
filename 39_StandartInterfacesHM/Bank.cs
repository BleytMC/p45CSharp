using System.Collections;

namespace _39_StandartInterfacesHM
{
    class Bank : IEnumerable
    {
        Account[] accounts;

        public Bank(Account[] accounts)
        {
            this.accounts = accounts;
        }

        public IEnumerator GetEnumerator()
        {
            return new BankEnumerator(accounts);
        }

        public void Sort()
        {
            Array.Sort(accounts);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(accounts, comparer);
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (Account account in accounts) str += account.ToString() + "\n";
            return str;
        }
    }
}
