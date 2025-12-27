using System.Collections;

namespace _39_StandartInterfacesHM
{
    internal class AccountCreationDateComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if(x is Account &&  y is Account) return (x as Account).CreationDate.CompareTo((y as Account).CreationDate);
            throw new NotImplementedException();
        }
    }
}
