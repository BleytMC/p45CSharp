namespace _04_Classes
{
    class Bank
    {
        private static int balance = 10000;

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Credit(int amount)
        {
            balance -= amount;
        }

        public static int GetBalance()
        {
            return balance;
        }
    }
}
