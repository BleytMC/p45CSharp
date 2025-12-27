using System.Globalization;

namespace _39_StandartInterfacesHM
{
    class Account : IComparable, ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreationDate { get; set; }
        public double Balance { get; set; }

        public Account(string name, string surname, DateTime creationDate, double balance)
        {
            Name = name;
            Surname = surname;
            CreationDate = creationDate;
            Balance = balance;
        }

        public int CompareTo(object? obj)
        {
            if(obj is Account)
            {
                Account other = obj as Account;
                return Surname.CompareTo(other.Surname);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Name} {Surname}\n\tCreation Date: {CreationDate}\n\tBalance: {Balance}$";
        }

        public object Clone()
        {
            Account account = (Account)MemberwiseClone();
            return account;
        }
    }
}
