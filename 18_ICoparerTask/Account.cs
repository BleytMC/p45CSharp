namespace _18_ICoparerTask
{
    class Account : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreationTime { get; set; }
        public double Balance { get; set; }

        public Account(string firstName, string lastName, DateTime creationTime, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CreationTime = creationTime;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\n\tCreated: {CreationTime}\n\tBalance: {Balance}";
        }

        public object Clone()
        {
            Account account = (Account)this.MemberwiseClone();
            return account;
        }
    }
}
