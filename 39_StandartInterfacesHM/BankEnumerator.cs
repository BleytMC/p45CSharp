using System.Collections;

namespace _39_StandartInterfacesHM
{
    class BankEnumerator : IEnumerator
    {

        Account[] accounts;
        int pos = -1;

        public BankEnumerator(Account[] accounts)
        {
            this.accounts = accounts;
        }

        public object Current
        {
            get {  return accounts[pos]; }
        }

        public bool MoveNext()
        {
            if(pos < accounts.Length - 1)
            {
                pos++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
