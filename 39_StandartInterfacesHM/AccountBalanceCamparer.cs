using System.Collections;

namespace _39_StandartInterfacesHM
{
    class AccountBalanceCamparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Account && y is Account) return (x as Account).Balance.CompareTo((y as Account).Balance);
            throw new NotImplementedException();
        }
    }
}
